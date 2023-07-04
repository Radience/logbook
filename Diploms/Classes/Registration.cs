namespace Diplom.Classes
{
    class Registration
    {
        public static bool Registr(string second_name, string name, string patronymic, string date_birthday, string num_phone, string num_phone_parent, string num_phone_parent_second, string series, string num, string codedep, string login, string password)
        {
            if (Model.MainModel.SetDataTable($"insert into Accounts values ('{login}', '{password}', 1)" +
                                             $"insert into Student values((select max(id_account) from Accounts), '{second_name}', '{name}', '{patronymic}', (select id_group from Group_ where CONCAT(id_specialization,'-',number_course,char_group,commerce) = '{Model.GroupModel.group}'), '{date_birthday}', '{num_phone}', '{num_phone_parent}', '{num_phone_parent_second}', '{series}', '{num}', '{codedep}', @image)", true) == true)
            {
                Messages.MsgBox msgBox = new Messages.MsgBox("Успешно");
                msgBox.Show();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}