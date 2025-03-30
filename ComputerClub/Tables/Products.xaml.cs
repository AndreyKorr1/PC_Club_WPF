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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        public Products()
        {
            InitializeComponent();
            //DGproduct.ItemsSource = PC_ClubEntities4.GetContext().Product.ToList();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var ProductForRemoving = DGproduct.SelectedItems.Cast<Product>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ProductForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities4.GetContext().Product.RemoveRange(ProductForRemoving);
                    PC_ClubEntities4.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGproduct.ItemsSource = PC_ClubEntities4.GetContext().Product.ToList();
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
                PC_ClubEntities4.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGproduct.ItemsSource = PC_ClubEntities4.GetContext().Product.ToList();
            }
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductAdd((sender as Button).DataContext as Product));
        }
    }
}
 