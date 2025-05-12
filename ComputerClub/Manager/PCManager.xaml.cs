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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class PCManager : Page
    {
        public PCManager()
        {
            InitializeComponent();
            //DGpc.ItemsSource = PC_ClubEntities4.GetContext().Pc.ToList();
            
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var PcForRemoving = DGpcManager.SelectedItems.Cast<Pc>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {PcForRemoving.Count()} элементов?", "Внимание", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities5.GetContext().Pc.RemoveRange(PcForRemoving);
                    PC_ClubEntities5.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGpcManager.ItemsSource = PC_ClubEntities5.GetContext().Pc.ToList();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PcAddPageManager(null));
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainManager());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities5.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGpcManager.ItemsSource = PC_ClubEntities5.GetContext().Pc.ToList();
            }
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PcAddPageManager((sender as Button).DataContext as Pc));
        }
    }
}
