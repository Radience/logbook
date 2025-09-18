using Diplom.Model;
using Diplom.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Diplom.Classes
{
    class Authorization
    {
        public static bool LogIn(string login, string password)
        {
            try
            {
                Model.MainModel.GetDataTable($"SELECT * FROM Accounts WHERE login = '{login}' and password = '{password}'");
                foreach (DataRow row in Model.MainModel.dataTable.Rows)
                {
                    Model.Accounts.id_account = Convert.ToInt32(row["id_account"].ToString());
                    Model.Accounts.id_role = Convert.ToInt32(row["id_role"].ToString());
                }
                Model.MainModel.connection.Close();
                if (Model.Accounts.id_role == 1)
                    Student();
                else if (Model.Accounts.id_role == 2)
                    Teacher();
                return true;
            }
            catch(Exception ex)
            {
                Messages.MsgBox msgBox = new Messages.MsgBox(ex.ToString());
                msgBox.Show();
            }
            return false;
        }

        public static void Student()
        {
            object photo = "";
            Model.MainModel.GetDataTable($"SELECT Student.id_account, id_student, second_name, name_, patronymic, Student.id_group, date_birthday, number_phone, number_phone_parent, number_phone_parent_second, series_passport, number_passport, code_dep, photo, Accounts.login, Accounts.password, id_specialization, number_course, char_group, commerce FROM Student, Group_, Accounts WHERE Student.id_account = '{Model.Accounts.id_account}' and Accounts.id_account = Student.id_account and Student.id_group = Group_.id_group");
            foreach(DataRow row in Model.MainModel.dataTable.Rows)
            {
                photo = row["photo"];
                Model.Accounts.id_group = Convert.ToInt32(row["id_group"].ToString());
            }
            Classes.ObjectToByte.ObjectToByteArray(photo);
            Model.ListData.student = Classes.ConvertDataTableToList.ConvertDataTable<Model.Student>(Model.MainModel.dataTable);
        }

        public static void Teacher()
        {
            object photo = "";
            Model.MainModel.GetDataTable($"SELECT Teacher.id_account, id_teacher, second_name, name_, patronymic, post_name, number_classroom, photo, login, password FROM Teacher, Post, Accounts WHERE Teacher.id_account = '{Accounts.id_account}' and Teacher.id_post = Post.id_post and Teacher.id_account = Accounts.id_account");
            foreach (DataRow row in Model.MainModel.dataTable.Rows)
            {
                photo = row["photo"];
            }
            Classes.ObjectToByte.ObjectToByteArray(photo);
            Model.ListData.teacher = Classes.ConvertDataTableToList.ConvertDataTable<Model.Teacher>(Model.MainModel.dataTable);
        }
    }
}
