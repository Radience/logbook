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
    /// Логика взаимодействия для TeacherMenu.xaml
    /// </summary>
    public partial class TeacherMenu : Page
    {
        public TeacherMenu()
        {
            InitializeComponent();
            DataContext = Model.ListData.teacher;
            Classes.News.getNews();
            FrameTeacherMenu.Navigate(new News());
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Width = 1000;
            FrameTeacherMenu.Navigate(new ProfileTeacher());
        }

        private void shedules_Click(object sender, RoutedEventArgs e)
        {
            FrameTeacherMenu.Navigate(new SchedulesForTeacher());
        }

        private void news_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Width = 800;
            FrameTeacherMenu.Navigate(new News());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Model.Accounts.id_role = 0;
            Model.Accounts.id_account = 0;
            NavigationService.Navigate(new Authorization());
        }

        private void book_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Width = 800;
            FrameTeacherMenu.Navigate(new Books());
        }
    }
}
