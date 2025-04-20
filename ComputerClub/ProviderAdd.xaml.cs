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
    /// Логика взаимодействия для ProviderAdd.xaml
    /// </summary>
    public partial class ProviderAdd : Page
    {
        private Provider _currentProvider = new Provider();
        public ProviderAdd(Provider selectedProvider)
        {
            InitializeComponent();

            if (selectedProvider != null)
            {
                _currentProvider = selectedProvider;
            }

            DataContext = _currentProvider;
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentProvider.CompanyName))
            {
                errors.AppendLine("Укажите название компании");
            }
            if (string.IsNullOrWhiteSpace(_currentProvider.Email))
            {
                errors.AppendLine("Укажите Email");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentProvider.ProviderID == 0)
            {
                PC_ClubEntities5.GetContext().Provider.Add(_currentProvider);
            }

            try
            {
                PC_ClubEntities5.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new Providers());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Providers());
        }
    }
}
