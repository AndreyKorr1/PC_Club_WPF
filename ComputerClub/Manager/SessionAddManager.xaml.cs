using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для SessionAdd.xaml
    /// </summary>
    public partial class SessionAddManager : Page
    {
        private Session _currentSession = new Session();
        public SessionAddManager(Session selectedSession)
        {
            InitializeComponent();
            if (selectedSession != null)
            {
                _currentSession = selectedSession;
            }
            DataContext = _currentSession;
            ComboUsers.ItemsSource = PC_ClubEntities5.GetContext().Users.ToList();
            ComboPc.ItemsSource = PC_ClubEntities5.GetContext().Pc.ToList();
            ComboRates.ItemsSource = PC_ClubEntities5.GetContext().Rate.ToList();
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();


            if (_currentSession.Users == null)
            {
                errors.AppendLine("Выберите пользователя");
            }
            if (_currentSession.Pc == null)
            {
                errors.AppendLine("Выберите компьютер");
            }
            if (_currentSession.Rate == null)
            {
                errors.AppendLine("Выберите тариф");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentSession.SessionID == 0)
            {
                PC_ClubEntities5.GetContext().Session.Add(_currentSession);
            }

            try
            {
                PC_ClubEntities5.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new SessionsManager());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SessionsManager());
        }
    }
}
