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
            //DGreceipt.ItemsSource = PC_ClubEntities5.GetContext().Receipt.ToList();
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceiptAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var ReceiptForRemoving = DGreceipt.SelectedItems.Cast<Receipt>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ReceiptForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities5.GetContext().Receipt.RemoveRange(ReceiptForRemoving);
                    PC_ClubEntities5.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGreceipt.ItemsSource = PC_ClubEntities5.GetContext().Receipt.ToList();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceiptAdd((sender as Button).DataContext as Receipt));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities5.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGreceipt.ItemsSource = PC_ClubEntities5.GetContext().Receipt.ToList();
            }
        }
    }
}
