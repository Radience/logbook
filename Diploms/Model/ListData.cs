using Diplom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Model
{
    public class ListData
    {
        public static List<Student> student { get; set; }
        public static List<News> news { get; set; }
        public static List<Student> students
        {
            get
            {
                return students;
            }
        }
        public static List<BackLogsStudent> backLoges { get; set; }
        public static List<Schedule> schedules { get; set; }
        public static List<Teacher> teacher { get; set; }
        public static List<Objects> objects { get; set; }
        public static List<Group_> groups { get; set; }
    }
}
