using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class ScheduleAll
    {
        public static void schedule(int day)
        {
            Model.MainModel.GetDataTable($"select Object_.name_object from Schedules, Object_ WHERE Schedules.id_object = Object_.id_object and day_in_week = '{day}' and Schedules.id_group = '{Model.Accounts.id_group}' order by pos_in_day asc");
            Model.ListData.schedules = Classes.ConvertDataTableToList.ConvertDataTable<Model.Schedule>(Model.MainModel.dataTable);
        }

        public static void scheduleForTeacher(int day)
        {
            Model.MainModel.GetDataTable($"select pos_in_day, Object_.name_object, CONCAT(id_specialization, '-', number_course, char_group, commerce) as groups from Object_, Schedules, Group_, Post_Object, Post WHERE Schedules.id_object = Post_Object.id_object and day_in_week = '{day}' and Schedules.id_group = Group_.id_group and Post_Object.id_object = Object_.id_object and Post_Object.id_post = Post.id_post and post_name = '{Model.Teacher.post_name}' order by pos_in_day asc");
            Model.ListData.schedules = Classes.ConvertDataTableToList.ConvertDataTable<Model.Schedule>(Model.MainModel.dataTable);
        }
    }
}