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
    /// Логика взаимодействия для AdministatorMenu.xaml
    /// </summary>
    public partial class AdministatorMenu : Page
    {
        public AdministatorMenu()
        {
            InitializeComponent();
            Model.MainModel.GetDataTable($"SELECT second_name, name_, patronymic, CONCAT(id_specialization, '-',number_course,char_group,commerce) as groupa, SUM(countNone) as countNone, SUM(countNone)*2 as countNoneInTime FROM Student, Group_, Student_Score WHERE Student.id_student = Student_Score.id_student and Student.id_group = Group_.id_group GROUP BY second_name, name_, patronymic, CONCAT(id_specialization, '-',number_course,char_group,commerce)");
            students.ItemsSource = Model.MainModel.dataTable.DefaultView;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Model.Accounts.id_role = 0;
            Model.Accounts.id_account = 0;
            NavigationService.Navigate(new Authorization());
        }
    }
}
