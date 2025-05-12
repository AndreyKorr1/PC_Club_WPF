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
    /// Логика взаимодействия для soldProducts.xaml
    /// </summary>
    public partial class soldProducts : Page
    {
        public soldProducts()
        {
            InitializeComponent();
            LoadProductSale();
        }

        private void LoadProductSale()
        {
            using (var context = PC_ClubEntities5.GetContext())
            {
                var ProductSale = context.GetProductSalesReport();
                ProductSalesReportGrid.ItemsSource = ProductSale;
            }
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Products());
        }
    }
}
