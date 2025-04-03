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
    /// Логика взаимодействия для DeliverAdd.xaml
    /// </summary>
    public partial class DeliverAdd : Page
    {
        private Deliver _currentDeliver = new Deliver();
        public DeliverAdd(Deliver selectedDeliver)
        {
            InitializeComponent();
            DataContext = _currentDeliver;
            ComboProvider.ItemsSource = PC_ClubEntities4.GetContext().Provider.ToList();
            ComboProduct.ItemsSource = PC_ClubEntities4.GetContext().Product.ToList();

            if (selectedDeliver != null)
            {
                _currentDeliver = selectedDeliver;
            }

            DataContext = _currentDeliver;
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            /*if (_currentDeliver.ProviderID.ToString() == null)
            {
                errors.AppendLine("Укажите id поставщика");
            }
            if (_currentDeliver.ProductID.ToString() == null)
            {
                errors.AppendLine("Укажите id продукта");
            }*/
            if (_currentDeliver.ProductQuantity < 1)
            {
                errors.AppendLine("Укажите колличество товара");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentDeliver.DeliverID == 0)
            {
                PC_ClubEntities4.GetContext().Deliver.Add(_currentDeliver);
            }

            try
            {
                PC_ClubEntities4.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new Deliver());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Delivers());
        }
    }
}
