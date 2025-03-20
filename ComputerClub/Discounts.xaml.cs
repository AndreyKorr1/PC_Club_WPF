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
    /// Логика взаимодействия для Discounts.xaml
    /// </summary>
    public partial class Discounts : Page
    {
        public Discounts()
        {
            InitializeComponent();
            DGdiscounts.ItemsSource = PC_ClubEntities4.GetContext().Discount.ToList();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
