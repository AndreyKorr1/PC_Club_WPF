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
    /// Логика взаимодействия для Sessions.xaml
    /// </summary>
    public partial class SessionsManager : Page
    {
        public SessionsManager()
        {
            InitializeComponent();
            DGsessionManager.ItemsSource = PC_ClubEntities5.GetContext().Session.ToList();
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SessionAddManager(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {
            var SessionForRemoving = DGsessionManager.SelectedItems.Cast<Session>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {SessionForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PC_ClubEntities5.GetContext().Session.RemoveRange(SessionForRemoving);
                    PC_ClubEntities5.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGsessionManager.ItemsSource = PC_ClubEntities5.GetContext().Session.ToList();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainManager());
        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SessionAddManager((sender as Button).DataContext as Session));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities5.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGsessionManager.ItemsSource = PC_ClubEntities5.GetContext().Session.ToList();
            }
        }
    }
}
