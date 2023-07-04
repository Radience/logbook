using Diplom.Model;
using System.Data;

namespace Diplom.Classes
{
    public class News
    {
        public static void getNews()
        {
            Model.MainModel.GetDataTable($"SELECT * FROM News");
            Model.ListData.news = ConvertDataTableToList.ConvertDataTable<Model.News>(Model.MainModel.dataTable);
        }
    }
}
