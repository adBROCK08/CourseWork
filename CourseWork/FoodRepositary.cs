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
                        food.FoodName = reader.GetString(1);
                        food.CaloriesPer100g = reader.GetInt32(2);
                        Foods.Add(food);
                    }
                }
            }
            return Foods;
        }

        public Foods GetFilteredFoods(int foodID)
        {
            Foods food = null;
            string sql = "SELECT * FROM tblFoods WHERE foodid = ?"; 
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@foodid", foodID); 

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        food = new Foods
                        {
                            FoodID = reader.GetInt32(0), 
                            FoodName = reader.GetString(1), 
                            CaloriesPer100g = reader.GetInt32(2) 
                        };
                    }
                }
            }

            return food;
        }

        public void AddFood(Foods food)
        {
            string sql = "INSERT INTO tblFoods (FoodName, CaloriesPer100g) VALUES (?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", food.FoodName);
                cmd.Parameters.AddWithValue("@CaloriesPer100g", food.CaloriesPer100g);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteFood(int foodID)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            string sql = "DELETE FROM tblFoods WHERE FoodID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@FoodID", foodID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateFood(Foods food)
        {
            string sql = "UPDATE tblFood SET FoodName = ?, CaloriesPer100g = ?, WHERE FoodID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@FoodName", food.FoodName);
                cmd.Parameters.AddWithValue("@CaloriesPer100g", food.CaloriesPer100g);
                cmd.Parameters.AddWithValue("@FoodID", food.FoodID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }


        public List<FoodLog> GetFoodLog()
        {
            List<FoodLog> FoodLog = new List<FoodLog>();

            string sql = "SELECT * FROM tblFoodLog";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FoodLog foodLog = new FoodLog();
                        foodLog.LogID = reader.GetInt32(0);
                        foodLog.FoodID = reader.GetInt32(1);
                        foodLog.Grams = reader.GetInt32(2);                      
                        foodLog.UserID = reader.GetInt32(3);
                        foodLog.LogDate = reader.GetDateTime(4);
                        FoodLog.Add(foodLog);
                    }
                }
            }
            return FoodLog;
        }

        public void AddFoodLog(FoodLog foodLog)
        {
            string sql = "INSERT INTO tblFoodLog (Grams, LogDate) VALUES (?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Grams", foodLog.Grams);
                cmd.Parameters.AddWithValue("@LogDate", foodLog.LogDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
