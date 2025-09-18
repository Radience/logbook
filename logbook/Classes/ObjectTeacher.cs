using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class ObjectTeacher
    {
        public static void getObjects()
        {
            Model.MainModel.GetDataTable($"SELECT name_object FROM Object_, Post_Object, Post WHERE Post_Object.id_object = Object_.id_object and Post_Object.id_post = Post.id_post and post_name = '{Model.Teacher.post_name}'");
            Model.ListData.objects = Classes.ConvertDataTableToList.ConvertDataTable<Model.Objects>(Model.MainModel.dataTable);
        }
    }
}
