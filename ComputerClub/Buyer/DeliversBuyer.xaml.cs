using ComputerClub.Buyer;
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
    /// Логика взаимодействия для Delivers.xaml
    /// </summary>
    public partial class DeliversBuyer : Page
    {
        public DeliversBuyer()
        {
            InitializeComponent();
            //DGdelivers.ItemsSource = PC_ClubEntities4.GetContext().Deliver.ToList();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainBuyer());
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliverBuyerAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var DeliverForRemoving = DGdeliversBuyer.SelectedItems.Cast<Deliver>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {DeliverForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities5.GetContext().Deliver.RemoveRange(DeliverForRemoving);
                    PC_ClubEntities5.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGdeliversBuyer.ItemsSource = PC_ClubEntities5.GetContext().Deliver.ToList();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities5.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGdeliversBuyer.ItemsSource = PC_ClubEntities5.GetContext().Deliver.ToList();
            }
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliverBuyerAdd((sender as Button).DataContext as Deliver));
        }
    }
}
