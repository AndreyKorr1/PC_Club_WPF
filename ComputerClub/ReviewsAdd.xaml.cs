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
    /// Логика взаимодействия для ReviewsAdd.xaml
    /// </summary>
    public partial class ReviewsAdd : Page
    {
        private Reviews _currentReview = new Reviews();
        public ReviewsAdd()
        {
            InitializeComponent();
            DataContext = _currentReview;
            ComboUsers.ItemsSource = PC_ClubEntities5.GetContext().Users.ToList();
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentReview.Rating < 0 || _currentReview.Rating > 5) 
            {
                errors.AppendLine("Укажите корректный рейтинг");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentReview.ReviewID == 0)
            {
                PC_ClubEntities5.GetContext().Reviews.Add(_currentReview);
            }

            try
            {
                PC_ClubEntities5.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new PC());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reviews());
        }
    }
}
