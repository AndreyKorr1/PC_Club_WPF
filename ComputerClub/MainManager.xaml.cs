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
    /// Логика взаимодействия для MainManager.xaml
    /// </summary>
    public partial class MainManager : Page
    {
        public MainManager()
        {
            InitializeComponent();
        }

        private void BtPC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PCManager());
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliversManager());
        }

        private void BtDis_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiscountsManager());
        }

        private void BtPr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsManager());
        }

        private void BtRev_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReviewsManager());
        }

        private void BtProv_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProvidersManager());
        }

        private void BtRa_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RatesManager());
        }

        private void BtRe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceiptsManager());
        }

        private void BtSe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SessionsManager());
        }

        private void BtUs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UsersManager());
        }

        private void BtExit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Enter());
        }
    }
}
