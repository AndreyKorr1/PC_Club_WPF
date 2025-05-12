using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }



        private void BtPC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PC());
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Delivers());
        }

        private void BtDis_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Discounts());
        }

        private void BtPr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Products());
        }

        private void BtRev_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reviews());
        }

        private void BtRa_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Rates());
        }

        private void BtRe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Receipts());
        }

        private void BtSe_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sessions());
        }

        private void BtUs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Users1());
        }

        private void BtProv_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Providers());
        }
    }
}
