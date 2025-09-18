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
    /// Логика взаимодействия для News.xaml
    /// </summary>
    public partial class News : Page
    {
        public News()
        {
            InitializeComponent();
            NewsListBox.ItemsSource = Model.ListData.news;
        }

        private void NewsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new FullNews(NewsListBox.SelectedItem));
        }
    }
}
