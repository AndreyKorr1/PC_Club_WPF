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
            //DGdiscounts.ItemsSource = PC_ClubEntities4.GetContext().Discount.ToList();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiscountAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var DiscountForRemoving = DGdiscounts.SelectedItems.Cast<Discount>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {DiscountForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities4.GetContext().Discount.RemoveRange(DiscountForRemoving);
                    PC_ClubEntities4.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGdiscounts.ItemsSource = PC_ClubEntities4.GetContext().Discount.ToList();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiscountAdd((sender as Button).DataContext as Discount));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities4.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGdiscounts.ItemsSource = PC_ClubEntities4.GetContext().Discount.ToList();
            }
        }
    }
}
