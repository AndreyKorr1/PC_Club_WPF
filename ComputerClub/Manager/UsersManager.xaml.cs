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
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class UsersManager : Page
    {
        public UsersManager()
        {
            InitializeComponent();
            DGuserManager.ItemsSource = PC_ClubEntities5.GetContext().Users.ToList();
        }


        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
    }
}
