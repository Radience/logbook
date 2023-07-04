using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class UpdateStudentProfile
    {
        public static bool updateStudentProfile(string second_name, string name, string patronymic, string date_birthday, string num_phone, string num_phone_parent, string num_phone_parent_second, string series, string num, string codedep, string login, string password, bool isSelectedPhoto)
        {
            if (isSelectedPhoto == true)
            {
                if (Model.MainModel.SetDataTable($"UPDATE Accounts SET login = '{login}', password = '{password}' WHERE id_account = '{Model.Accounts.id_account}'" +
                                                 $"UPDATE Student SET second_name = '{second_name}', name_ = '{name}', patronymic = '{patronymic}', date_birthday = '{date_birthday}', number_phone = '{num_phone}', number_phone_parent = '{num_phone_parent}', number_phone_parent_second = '{num_phone_parent_second}', series_passport = '{series}', number_passport = '{num}', code_dep = '{codedep}', photo = @image WHERE id_account = '{Model.Accounts.id_account}'", true) == true)
                {
                    Authorization.Student();
                    Messages.MsgBox msgBox = new Messages.MsgBox("Успешно");
                    msgBox.Show();
                    return true;
                }
            }
            else if (isSelectedPhoto == false)
            {
                if (Model.MainModel.SetDataTable($"UPDATE Accounts SET login = '{login}', password = '{password}' WHERE id_account = '{Model.Accounts.id_account}'" +
                                                 $"UPDATE Student SET second_name = '{second_name}', name_ = '{name}', patronymic = '{patronymic}', date_birthday = '{date_birthday}', number_phone = '{num_phone}', number_phone_parent = '{num_phone_parent}', number_phone_parent_second = '{num_phone_parent_second}', series_passport = '{series}', number_passport = '{num}', code_dep = '{codedep}' WHERE id_account = '{Model.Accounts.id_account}'", false) == true)
                {
                    Authorization.Student();
                    Messages.MsgBox msgBox = new Messages.MsgBox("Успешно");
                    msgBox.Show();
                    return true;
                }
            }
            return false;
        }
    }
}
