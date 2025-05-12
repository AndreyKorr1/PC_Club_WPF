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

namespace ComputerClub.Buyer
{
    /// <summary>
    /// Логика взаимодействия для MainBuyer.xaml
    /// </summary>
    public partial class MainBuyer : Page
    {
        public MainBuyer()
        {
            InitializeComponent();
        }

        private void ProdClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsBuyer());
        }

        private void DelivClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliversBuyer());
        }

        private void ProvClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProvidersBuyer());
        }
    }
}
