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
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Page
    {
        private Product _currentProduct = new Product();
        public ProductAdd(Product selectedProduct)
        {
            InitializeComponent();

            if (selectedProduct != null)
            {
                _currentProduct = selectedProduct;
            }

            DataContext = _currentProduct;
        }
        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentProduct.ProductName))
            {
                errors.AppendLine("Укажите название");
            }
            if (_currentProduct.ProductPrice < 0)
            {
                errors.AppendLine("Укажите цену");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentProduct.ProductID == 0)
            {
                PC_ClubEntities4.GetContext().Product.Add(_currentProduct);
            }

            try
            {
                PC_ClubEntities4.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new Products());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Products());
        }
    }
}
