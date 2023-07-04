using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    public class UpdateTeacherProfile
    {
        public static bool updateTeacherProfile(string second_name, string name, string patronymic, string login, string password, bool isSelectedPhoto)
        {
            if (isSelectedPhoto == true)
            {
                if (Model.MainModel.SetDataTable($"UPDATE Accounts SET login = '{login}', password = '{password}' WHERE id_account = '{Model.Accounts.id_account}'" +
                                                 $"UPDATE Teacher SET second_name = '{second_name}', name_ = '{name}', patronymic = '{patronymic}', photo = @image WHERE id_account = '{Model.Accounts.id_account}'", true) == true)
                {
                    Authorization.Teacher();
                    Messages.MsgBox msgBox = new Messages.MsgBox("Успешно");
                    msgBox.Show();
                    return true;
                }
            }
            else if (isSelectedPhoto == false)
            {
                if (Model.MainModel.SetDataTable($"UPDATE Accounts SET login = '{login}', password = '{password}' WHERE id_account = '{Model.Accounts.id_account}'" +
                                                 $"UPDATE Teacher SET second_name = '{second_name}', name_ = '{name}', patronymic = '{patronymic}' WHERE id_account = '{Model.Accounts.id_account}'", false) == true)
                {
                    Authorization.Teacher();
                    Messages.MsgBox msgBox = new Messages.MsgBox("Успешно");
                    msgBox.Show();
                    return true;
                }
            }
            return false;
        }
    }
}
