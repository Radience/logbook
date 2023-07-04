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
    /// Логика взаимодействия для Schedules.xaml
    /// </summary>
    public partial class Schedules : Page
    {
        private static List<string> daysWeek = new List<string>() { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота"};
        private static int day = 1;
        private static int elementList = 0;
        public Schedules()
        {
            InitializeComponent();
            day = 1;
            elementList = 0;
            dayInWeek.Text = daysWeek[elementList];
            Classes.ScheduleAll.schedule(day);
            schedule.ItemsSource = Model.MainModel.dataTable.DefaultView;
        }

        private void nextDay_Click(object sender, RoutedEventArgs e)
        {
            elementList++;
            day++;
            if (day == 6)
            {
                nextDay.Visibility = Visibility.Hidden;
            }
            else
            {
                backDay.Visibility=Visibility.Visible;
            }     
            dayInWeek.Text = daysWeek[elementList];
            Classes.ScheduleAll.schedule(day);
            schedule.ItemsSource = Model.MainModel.dataTable.DefaultView;
        }

        private void backDay_Click(object sender, RoutedEventArgs e)
        {
            elementList--;
            day--;
            if (day == 1)
            {
                backDay.Visibility = Visibility.Hidden;
            }
            else
            {
                nextDay.Visibility = Visibility.Visible;
            }
            dayInWeek.Text = daysWeek[elementList];
            Classes.ScheduleAll.schedule(day);
            schedule.ItemsSource = Model.MainModel.dataTable.DefaultView;
        }
    }
}
