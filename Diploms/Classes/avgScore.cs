using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Classes
{
    class avgScore
    {
        private static string score;
        private static double avg;
        private static int countNONE;
        public static bool newScore(string newscore, object student)
        {
            double newavg = 0;
            Model.MainModel.dataRowView = student as DataRowView;
            score = Model.MainModel.dataRowView.Row[16].ToString();
            avg = Convert.ToDouble(Model.MainModel.dataRowView.Row[17].ToString());
            countNONE = Convert.ToInt32(Model.MainModel.dataRowView.Row[18].ToString());
            if(newscore == "Н")
            {
                countNONE++;
                score += newscore;
                Model.MainModel.SetDataTable($"UPDATE Student_Score SET score = '{score}', countNone = {countNONE} WHERE id_student = '{Model.MainModel.dataRowView.Row[1].ToString()}' and id_object = '{Model.MainModel.dataRowView.Row[19].ToString()}'", false);
                return true;
            }
            else
            {
                int count = score.Length - countNONE;
                double sum = avg * count;
                newavg = (sum + Convert.ToInt32(newscore)) / ((score.Length - countNONE) + 1);
                score += newscore;
                Model.MainModel.SetDataTable($"UPDATE Student_Score SET score = '{score}', avgScore = {Math.Round(newavg, 2).ToString("0,00", CultureInfo.GetCultureInfo("en-US"))}, countNone = {countNONE} WHERE id_student = '{Model.MainModel.dataRowView.Row[1].ToString()}' and id_object = '{Model.MainModel.dataRowView.Row[19].ToString()}'", false);
                return true;
            }
        }
    }
}
