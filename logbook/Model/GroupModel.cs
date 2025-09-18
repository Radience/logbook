using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Model
{
    class GroupModel
    {
        public static string group { get; set; }

        public static void getGroups()
        {
            MainModel.GetDataTable($"select CONCAT(id_specialization, '-', number_course,char_group,commerce) as groups from Group_");
        }
    }
}
