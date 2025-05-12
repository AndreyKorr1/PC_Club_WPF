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
    public partial class RatesManager : Page
    {
        public RatesManager()
        {
            InitializeComponent();
            DGrateManager.ItemsSource = PC_ClubEntities5.GetContext().Rate.ToList();
        }
        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainManager());
        }


    }
}
