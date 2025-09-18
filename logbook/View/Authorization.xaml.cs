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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.Authorization.LogIn(login.Text, password.Password) == true)
            {
                if (Model.Accounts.id_role == 1)
                {
                    NavigationService.Navigate(new StudentMenu());
                }
                else if (Model.Accounts.id_role == 2)
                {
                    NavigationService.Navigate(new TeacherMenu());
                }
                else if (Model.Accounts.id_role == 3)
                {
                    NavigationService.Navigate(new AdministatorMenu());
                }
                else if(Model.Accounts.id_role == 0)
                {
                    Messages.MsgBox msgBox = new Messages.MsgBox("Аккаунт не существует");
                    msgBox.Show();
                }
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationMenu());
        }
    }
}
