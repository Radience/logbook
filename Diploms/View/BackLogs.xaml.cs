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

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для BackLogs.xaml
    /// </summary>
    public partial class BackLogs : Page
    {
        
        public BackLogs()
        {
            InitializeComponent();
            Classes.Backlogs.backLogs();
            backLogListBox.ItemsSource = Model.ListData.backLoges;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new News());
        }
    }
}
