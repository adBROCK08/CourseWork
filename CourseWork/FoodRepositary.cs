using System;
using System.Collections.Generic;
using System.Data;
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
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CourseWork.accdb";

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
            DialogResult result = MessageBox.Show("Are you sure you want to delete this food?","Delete Food",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string sqlLogs = "DELETE FROM tblFoodLog WHERE FoodID = ?";
                    using (OleDbCommand cmdLogs = new OleDbCommand(sqlLogs, conn))
                    {
                        cmdLogs.Parameters.AddWithValue("@FoodID", foodID);
                        cmdLogs.ExecuteNonQuery();
                    }

                    string sqlFood = "DELETE FROM tblFoods WHERE FoodID = ?";
                    using (OleDbCommand cmdFood = new OleDbCommand(sqlFood, conn))
                    {
                        cmdFood.Parameters.AddWithValue("@FoodID", foodID);
                        cmdFood.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Food deleted successfully");
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

       

        public static void AddFoodLog(FoodLog log)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string sql = "INSERT INTO tblFoodLog (FoodID, Grams, LogDate, UserID) VALUES (?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FoodID", log.FoodID);
                    cmd.Parameters.AddWithValue("@Grams", log.Grams);
                    cmd.Parameters.AddWithValue("@LogDate", log.LogDate);
                    cmd.Parameters.AddWithValue("@UserID", log.UserID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static double GetTotalCalories(int userID, DateTime date)
        {
            double total = 0;

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string sql = @"
                SELECT SUM((f.CaloriesPer100g / 100) * l.Grams)
                FROM tblFoodLog l
                INNER JOIN tblFoods f ON l.FoodID = f.FoodID
                WHERE l.UserID = ? AND l.LogDate = ?";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", userID);
                    cmd.Parameters.AddWithValue("@p2", date);

                    conn.Open();

                    var result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        total = Convert.ToDouble(result);
                    }
                }
            }

            return total;
        }

        public static DataTable GetFoodLogForDate(int userID, DateTime date)
        {
            DataTable table = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string sql = @"
                SELECT l.logID, f.FoodName, l.Grams,(f.CaloriesPer100g / 100) * l.Grams AS Calories
                FROM tblFoodLog l
                INNER JOIN tblFoods f ON l.FoodID = f.FoodID
                WHERE l.UserID = ? AND l.LogDate = ?";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", userID);
                    cmd.Parameters.AddWithValue("@p2", date);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        public static void DeleteFoodLog(int LogID)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string sql = "DELETE FROM tblFoodLog WHERE LogID = ?";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", LogID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
