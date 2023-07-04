using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class Backlogs
    {
        public static void backLogs()
        {
            Model.MainModel.GetDataTable($"SELECT Object_.name_object, Topics.name_topic FROM Topics, Object_, BackLog, Topics_Object, Student WHERE BackLog.id_topic = Topics_Object.id_topic and Topics_Object.id_topic = Topics.id_topic and Topics_Object.id_object = Object_.id_object and BackLog.id_student = Student.id_student and Student.id_account = '{Model.Accounts.id_account}'" +
                                         $"Order by name_object asc");
            Model.ListData.backLoges = Classes.ConvertDataTableToList.ConvertDataTable<Model.BackLogsStudent>(Model.MainModel.dataTable);
        }
    }
}
