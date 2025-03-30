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
    /// Логика взаимодействия для RatesAdd.xaml
    /// </summary>
    public partial class RatesAdd : Page
    {
        private Rate _currentRate = new Rate();
        public RatesAdd(Rate selectedRate)
        {
            InitializeComponent();

            if (selectedRate != null)
            {
                _currentRate = selectedRate;
            }

            DataContext = _currentRate;
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentRate.RateName))
            {
                errors.AppendLine("Введите название тарифа");
            }
            if (_currentRate.RatePrice < 1)
            {
                errors.AppendLine("Укажите цену тарифа");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentRate.RateID == 0)
            {
                PC_ClubEntities4.GetContext().Rate.Add(_currentRate);
            }

            try
            {
                PC_ClubEntities4.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new Rates());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Rates());
        }
    }
}
