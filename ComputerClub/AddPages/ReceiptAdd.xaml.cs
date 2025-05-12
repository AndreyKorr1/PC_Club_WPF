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
    /// Логика взаимодействия для ReceiptAdd.xaml
    /// </summary>
    public partial class ReceiptAdd : Page
    {
        private Receipt _currentReceipt = new Receipt();
        public ReceiptAdd(Receipt selectedReceipt)
        {
            InitializeComponent();
            if (selectedReceipt != null)
            {
                _currentReceipt = selectedReceipt;
            }
            DataContext = _currentReceipt;
            ComboSession.ItemsSource = PC_ClubEntities5.GetContext().Session.ToList();
            ComboProduct.ItemsSource = PC_ClubEntities5.GetContext().Product.ToList();
            ComboDiscount.ItemsSource = PC_ClubEntities5.GetContext().Discount.ToList();
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();


            if (_currentReceipt.Session == null)
            {
                errors.AppendLine("Выберите сессию");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentReceipt.SessionID == 0)
            {
                PC_ClubEntities5.GetContext().Receipt.Add(_currentReceipt);
            }

            try
            {
                PC_ClubEntities5.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new Receipts());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Receipts());
        }
    }
}
