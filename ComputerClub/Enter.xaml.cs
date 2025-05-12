using ComputerClub.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Page
    {
        public Enter()
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

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            Auth(LoginText.Text, PasswordText.Password);
        }

        public bool Auth(string Login, string Password)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }

            string _password = GetHash(Password);
            using (var db = new PC_ClubEntities5())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.FirstName == Login && u.Password == _password);
                if (user == null) { MessageBox.Show("Пользователь с такими данными не найден!"); return false; }
                if (LoginText.Text == "Manager") {
                    NavigationService.Navigate(new MainManager());
                }
                else if (LoginText.Text == "Buyer")
                {
                    NavigationService.Navigate(new MainBuyer());
                }
                else if (LoginText.Text == "Admin")
                {
                    NavigationService.Navigate(new Page1());
                }
                else
                {
                    MessageBox.Show("у этого пользователя нет прав");
                }
                return true;
            }
        }


        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }

    }
}
