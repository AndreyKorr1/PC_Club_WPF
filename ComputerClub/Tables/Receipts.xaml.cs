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
    /// Логика взаимодействия для Receipts.xaml
    /// </summary>
    public partial class Receipts : Page
    {
        public Receipts()
        {
            InitializeComponent();
            DGreceipt.ItemsSource = PC_ClubEntities5.GetContext().Receipt.ToList();
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
