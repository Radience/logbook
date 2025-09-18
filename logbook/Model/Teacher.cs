using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Model
{
    public class Teacher
    {
        public static int id_account { get; set; }
        public static int id_teacher { get; set; }
        public static string second_name { get; set; }
        public static string name_ { get; set; }
        public static string patronymic { get; set; }
        public static string post_name { get; set; }
        public static int number_classroom { get; set; }
        public static byte[] photo { get; set; }
        public static string login { get; set; }
        public static string password { get; set; }

    }
}
