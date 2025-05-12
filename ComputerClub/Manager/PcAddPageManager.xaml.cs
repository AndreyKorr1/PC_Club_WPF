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
    /// Логика взаимодействия для PcAddPage.xaml
    /// </summary>
    public partial class PcAddPageManager : Page
    {
        private Pc _currentPc = new Pc();
        public PcAddPageManager(Pc selectedPc)
        {
            InitializeComponent();

            if (selectedPc != null )
            {
                _currentPc = selectedPc;
            }

            DataContext = _currentPc;
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            
            if (string.IsNullOrWhiteSpace(_currentPc.Video_Card))
            {
                errors.AppendLine("Укажите видеокарту");
            }
            if (string.IsNullOrWhiteSpace(_currentPc.CPU))
            {
                errors.AppendLine("Укажите процессор");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentPc.PcID == 0)
            {
                PC_ClubEntities5.GetContext().Pc.Add(_currentPc);
            }

            try
            {
                PC_ClubEntities5.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.Navigate(new PCManager());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PCManager());
        }
    }
}
