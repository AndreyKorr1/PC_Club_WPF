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
    /// Логика взаимодействия для DiscountAdd.xaml
    /// </summary>
    public partial class DiscountAdd : Page
    {
        private Discount _currentDiscount = new Discount();
        public DiscountAdd(Discount selectedDiscount)
        {
            InitializeComponent();

            if (selectedDiscount != null)
            {
                _currentDiscount = selectedDiscount;
            }

            DataContext = _currentDiscount;
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentDiscount.DiscountName))
            {
                errors.AppendLine("Укажите название скидки");
            }
            if (_currentDiscount.Procent < 1)
            {
                errors.AppendLine("Укажите процент скидки");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentDiscount.DiscountID == 0)
            {
                PC_ClubEntities5.GetContext().Discount.Add(_currentDiscount);
            }

            try
            {
                PC_ClubEntities5.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new Discounts());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Discounts());
        }
    }
}
