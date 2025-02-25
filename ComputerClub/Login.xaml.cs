using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComputerClub
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string GetHash(string password)
        {
            using (var hash = SHA1.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
            }
        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginText.Text.Length > 0)
            {
                using (var db = new Entities())
                {
                    var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == loginText.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Пользователь с такими данными уже существует!");
                        return;
                    }
                }

                bool en = true;
                bool number = false;
                for (int i = 0; i < passwordText.Password.Length; i++)
                {
                    if (passwordText.Password[i] >= 'A' && passwordText.Password[i] <= 'Z') en = false;
                    if (passwordText.Password[i] >= '0' && passwordText.Password[i] <= '9') number = true;
                }

                var regex = new Regex(@"^(\+7)\d{10}$");
                StringBuilder errors = new StringBuilder();

                if (passwordText.Password.Length < 6) errors.AppendLine("Пароль должен быть больше 6 символов");
                if (!regex.IsMatch(phoneText.Text)) errors.AppendLine("Укажите номер телефона в формате +7XXXXXXXXXX");
                if (en) errors.AppendLine("Пароль должен быть на английском языке");
                if (!number) errors.AppendLine("Пароль должен содержать хотя бы одну цифру");
                if (!isValidPhone(phone.Text)) errors.AppendLine("Введите корректный email");

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                else
                {
                    Entities db = new Entities();
                    Users userObject = new Users
                    {
                        Login = loginText.Text,
                        Password = GetHash(passwordText.Password),
                        Role = 1,
                        Data = dataText.Text,
                        Phone = phoneText.Text
                    };

                    db.Users.Add(userObject);
                    db.SaveChanges();
                    MessageBox.Show("Вы успешно зарегистрировались!", "Успешно!", MessageBoxButton.OK);
                    NavigationService.Navigate(new Uri("/Pages/AuthLog.xaml", UriKind.Relative));
                }
            }
            else MessageBox.Show("Укажите логин!");
        }
        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(loginText.Text) || string.IsNullOrEmpty(passwordText.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            string _password = GetHash(passwordText.Password);

            using (var db = new Entities())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == loginText.Text && u.Password == _password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }

                if (user.Role == 1)
                {
                    var newWindow = new UserWindow(user);
                    newWindow.Show();
                    MainWindow.closeWindow();  // Check the naming
                }
                else
                {
                    var newWindow = new AdminWindow(user);
                    newWindow.Show();
                    MainWindow.closeWindow(); // Check the naming
                }
            }
        }

    }
}
