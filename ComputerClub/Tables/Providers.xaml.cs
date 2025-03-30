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
    /// Логика взаимодействия для Providers.xaml
    /// </summary>
    public partial class Providers : Page
    {
        public Providers()
        {
            InitializeComponent();
            DGprovider.ItemsSource = PC_ClubEntities4.GetContext().Provider.ToList();
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProviderAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var ProviderForRemoving = DGprovider.SelectedItems.Cast<Provider>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ProviderForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities4.GetContext().Provider.RemoveRange(ProviderForRemoving);
                    PC_ClubEntities4.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGprovider.ItemsSource = PC_ClubEntities4.GetContext().Pc.ToList();
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
            NavigationService.Navigate(new ProviderAdd((sender as Button).DataContext as Provider));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities4.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGprovider.ItemsSource = PC_ClubEntities4.GetContext().Provider.ToList();
            }
        }
    }
}
