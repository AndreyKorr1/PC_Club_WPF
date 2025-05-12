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
    /// Логика взаимодействия для Reviews.xaml
    /// </summary>
    public partial class Reviews : Page
    {
        public Reviews()
        {
            InitializeComponent();
            //DGreviews.ItemsSource = PC_ClubEntities4.GetContext().Reviews.ToList();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void BtAdd_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReviewsAdd(null));
        }

        private void BtDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtEd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PC_ClubEntities5.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGreviews.ItemsSource = PC_ClubEntities5.GetContext().Reviews.ToList();
            }
        }
    }
}
