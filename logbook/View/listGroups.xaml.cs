using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для listGroups.xaml
    /// </summary>
    public partial class listGroups : Page
    {
        public listGroups(object item)
        {
            InitializeComponent();
            Model.MainModel.dataRowView = item as DataRowView;
            Classes.Groups.getGroups(Model.MainModel.dataRowView.Row[0].ToString());
            listGroup.ItemsSource = Model.MainModel.dataTable.DefaultView;
        }

        private void listGroup_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new listStudents(listGroup.SelectedItem));
        }
    }
}
