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
    public partial class Delivers : Page
    {
        public Delivers()
        {
            InitializeComponent();
            //DGdelivers.ItemsSource = PC_ClubEntities4.GetContext().Deliver.ToList();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliverAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var DeliverForRemoving = DGdelivers.SelectedItems.Cast<Deliver>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {DeliverForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities4.GetContext().Deliver.RemoveRange(DeliverForRemoving);
                    PC_ClubEntities4.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGdelivers.ItemsSource = PC_ClubEntities4.GetContext().Deliver.ToList();
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
                DGdelivers.ItemsSource = PC_ClubEntities4.GetContext().Deliver.ToList();
            }
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliverAdd((sender as Button).DataContext as Deliver));
        }
    }
}
