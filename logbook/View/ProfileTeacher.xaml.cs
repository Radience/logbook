using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для ProfileTeacher.xaml
    /// </summary>
    public partial class ProfileTeacher : Page
    {
        private static bool isSelectedPhoto = false;
        public ProfileTeacher()
        {
            InitializeComponent();
            DataContext = Model.ListData.teacher;
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new Microsoft.Win32.OpenFileDialog();
                bool? result = dialog.ShowDialog();
                if (result == true)
                {
                    photo.Source = BitmapFrame.Create(new Uri(dialog.FileName));
                    Model.Accounts.image_bytes = File.ReadAllBytes(dialog.FileName);
                    isSelectedPhoto = true;
                }
            }
            catch (Exception ex)
            {
                Messages.MsgBox msgBox = new Messages.MsgBox(ex.ToString());
                msgBox.Show();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            redactor.IsEnabled = true;
            load.Visibility = Visibility.Visible;
            update.Visibility = Visibility.Hidden;
            save.Visibility = Visibility.Visible;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.UpdateTeacherProfile.updateTeacherProfile(second_name.Text, name.Text, patronymic.Text, login.Text, password.Text, isSelectedPhoto) == true)
            {
                App.Current.MainWindow.Width = 800;
                NavigationService.Navigate(new News());
            }
        }
    }
}
