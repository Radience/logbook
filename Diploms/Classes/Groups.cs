using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class Groups
    {
        private static string item;
        public static void getGroups(string obj)
        {
            Model.MainModel.GetDataTable($"select DISTINCT Group_.id_group, CONCAT(Group_.id_specialization, '-', number_course, char_group, commerce) as groupa from Group_, Group_Object, Post_Object, Object_, Teacher, Post where Group_.id_group = Group_Object.id_group and Group_Object.id_object = Post_Object.id_object and Post_Object.id_object = Object_.id_object and Object_.name_object = '{obj}' and Post_Object.id_post = Post.id_post and post_name = '{Model.Teacher.post_name}'");
            item = obj;
        }

        public static void getStudents(int id)
        {
            Model.MainModel.GetDataTable($"SELECT * FROM Student, Student_Score, Object_ WHERE id_group = '{id}' and Student.id_student = Student_Score.id_student and Student_Score.id_object = Object_.id_object and Object_.name_object = '{item}' ORDER BY second_name ASC");
        }
    }
}
