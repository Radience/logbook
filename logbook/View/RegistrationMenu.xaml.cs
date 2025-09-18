using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для RegistrationMenu.xaml
    /// </summary>
    public partial class RegistrationMenu : Page
    {
        private static bool isSelectedPhoto = false;
        public RegistrationMenu()
        {
            InitializeComponent();
            Model.GroupModel.getGroups();
            group.ItemsSource = Model.MainModel.dataTable.DefaultView;
            this.number_phone.PreviewTextInput += new TextCompositionEventHandler(number_phone_PreviewTextInput);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization());
        }

        private void number_phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isSelectedPhoto = true;
                var dialog = new Microsoft.Win32.OpenFileDialog();
                bool? result = dialog.ShowDialog();
                if (result == true)
                {
                    photo.Source = BitmapFrame.Create(new Uri(dialog.FileName));
                    Model.Accounts.image_bytes = File.ReadAllBytes(dialog.FileName);
                }
            }
            catch(Exception ex)
            {
                Messages.MsgBox msgBox = new Messages.MsgBox(ex.ToString());
                msgBox.Show();
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (isSelectedPhoto == true)
            {
                if (Classes.Registration.Registr(second_name.Text, name.Text, patronymic.Text, date_birthday.SelectedDate.Value.ToString(), number_phone.Text, number_phone_parent.Text, number_phone_parent_second.Text, series.Text, num.Text, coddep.Text, login.Text, password.Text) == true)
                    NavigationService.Navigate(new Authorization());
            }
            else
            {
                Messages.MsgBox msgBox = new Messages.MsgBox("Выберите фото");
                msgBox.Show();
            }
        }

        private void group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.GroupModel.group = (group.SelectedItem as DataRowView).Row.ItemArray[0].ToString();
        }
    }
}
