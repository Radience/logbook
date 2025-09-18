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
    /// Логика взаимодействия для listStudents.xaml
    /// </summary>
    public partial class listStudents : Page
    {
        private int idGroup;
        public listStudents(object group)
        {
            InitializeComponent();
            Model.MainModel.dataRowView = group as DataRowView;
            idGroup = Convert.ToInt32(Model.MainModel.dataRowView.Row[0].ToString());
            Refresh();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.avgScore.newScore("5", listStud.SelectedItem) == true)
                Refresh();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.avgScore.newScore("4", listStud.SelectedItem) == true)
                Refresh();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.avgScore.newScore("3", listStud.SelectedItem) == true)
                Refresh();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (Classes.avgScore.newScore("2", listStud.SelectedItem) == true)
                Refresh();
        }

        private void none_Click(object sender, RoutedEventArgs e)
        {
            if(Classes.avgScore.newScore("Н", listStud.SelectedItem) == true)
                Refresh();
        }

        private void Refresh()
        {
            Classes.Groups.getStudents(idGroup);
            listStud.ItemsSource = Model.MainModel.dataTable.DefaultView;
        }
    }
}