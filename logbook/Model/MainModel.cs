using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.Model
{
    class MainModel
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DHMQJ5P;Initial Catalog=Diplomdb;Integrated Security=True");
        public static SqlDataAdapter adapter;
        public static SqlCommand command;
        public static DataTable dataTable;
        public static DataRowView dataRowView;


        public static DataTable GetDataTable(string query)
        {
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                Messages.MsgBox msgBox = new Messages.MsgBox(ex.ToString());
                msgBox.Show();
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool SetDataTable(string query, bool isParameters)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                if (isParameters == true)
                {
                    cmd.Parameters.Add("@image", SqlDbType.Image, 1000000);
                    cmd.Parameters["@image"].Value = Accounts.image_bytes;
                }
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(Exception ex)
            {
                Messages.MsgBox msgBox = new Messages.MsgBox(ex.ToString());
                msgBox.Show();
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
