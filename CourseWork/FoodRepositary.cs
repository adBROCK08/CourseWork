using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    internal class FoodRepositary
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CourseWork.accdb";

        public List<Foods> GetFood()
        {
            List<Foods> Foods = new List<Foods>();
            string sql = "SELECT * FROM tblFoods";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Foods food = new Foods();
                        food.FoodID = reader.GetInt32(0);
                        //food.FoodTypeID = reader.GetInt32(1);
                        food.FoodName = reader.GetString(2);
                        food.CaloriesPer100g = reader.GetInt32(3);
                        Foods.Add(food);
                    }
                }
            }
            return Foods;
        }

       

    }
}
