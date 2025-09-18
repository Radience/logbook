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
    /// Логика взаимодействия для StudentMenu.xaml
    /// </summary>
    public partial class StudentMenu : Page
    {
        public StudentMenu()
        {
            InitializeComponent();
            DataContext = Model.ListData.student;
            Classes.News.getNews();
            FrameStudentMenu.Navigate(new News());
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            App.Current.MainWindow.Width = 1000;
            FrameStudentMenu.Navigate(new ProfileStudent());
        }

        private void backlog_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            App.Current.MainWindow.Width = 1000;
            FrameStudentMenu.Navigate(new BackLogs());
        }

        private void shedules_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            FrameStudentMenu.Navigate(new Schedules());
        }

        private void news_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            App.Current.MainWindow.Width = 800;
            FrameStudentMenu.Navigate(new News());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Model.Accounts.id_role = 0;
            Model.Accounts.id_account = 0;
            NavigationService.Navigate(new Authorization());
        }

        private void Refresh()
        {
            DataContext = Model.ListData.student;
        }
    }
}
