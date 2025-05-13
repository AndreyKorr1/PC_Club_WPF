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
    /// Логика взаимодействия для Rates.xaml
    /// </summary>
    public partial class Rates : Page
    {
        public Rates()
        {
            InitializeComponent();
            //DGrate.ItemsSource = PC_ClubEntities4.GetContext().Rate.ToList();
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RatesAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var RateForRemoving = DGrate.SelectedItems.Cast<Rate>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {RateForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities5.GetContext().Rate.RemoveRange(RateForRemoving);
                    PC_ClubEntities5.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGrate.ItemsSource = PC_ClubEntities5.GetContext().Rate.ToList();
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
            NavigationService.Navigate(new RatesAdd((sender as Button).DataContext as Rate));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                var context = new PC_ClubEntities5(); // Или ваш метод GetContext()
                context.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGrate.ItemsSource = context.Rate.ToList();
            }
        }

        private void BtOtch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PopularRate());
        }
    }
}
