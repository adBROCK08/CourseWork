using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    internal class UserRepositary
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CourseWork.accdb";

        internal static IEnumerable<object> GetUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUser()
        {
            List<User> Users = new List<User>();
            string sql = "SELECT * FROM tblUserInfo";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.UserID = reader.GetInt32(0);
                        user.UserName = reader.GetString(1);
                        user.Age = reader.GetInt32(2);
                        user.Weight = reader.GetInt32(3);
                        user.Height = reader.GetInt32(4);
                        user.Gender = reader["Gender"].ToString();
                        user.CalorieGoal = reader.GetInt32(6);
                        user.Password = reader.GetString(7);
                        user.Role = reader.GetString(8);
                        Users.Add(user);
                    }
                }
            }
            return Users;
        }


        public void AddUser(User user)
        {

            string sql = @"INSERT INTO tblUserInfo 
            (UserName, Age, Weight, Height, Gender, CalorieGoal, [Password], [Role]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@p1", user.UserName);
                cmd.Parameters.AddWithValue("@p2", user.Age);
                cmd.Parameters.AddWithValue("@p3", user.Weight);
                cmd.Parameters.AddWithValue("@p4", user.Height);
                cmd.Parameters.AddWithValue("@p5", user.Gender);
                cmd.Parameters.AddWithValue("@p6", user.CalorieGoal);
                cmd.Parameters.AddWithValue("@p7", user.Password);
                cmd.Parameters.AddWithValue("@p8", user.Role);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public User GetFilteredUser(int userID)
        {
            User user = null;
            string sql = "SELECT * FROM tblUserInfo WHERE userid = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@userid", userID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            Weight = reader.GetInt32(3),
                            Height = reader.GetInt32(4),
                            Gender = reader.GetString(5),
                            CalorieGoal = reader.GetInt32(6),
                        };
                    }
                }
            }

            return user;
        }

        public void DeleteUser(int userID)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            string sql = "DELETE FROM tblUserInfo WHERE UserID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateUser(User user)
        {
            string sql = "UPDATE tblUserInfo SET UserName = ?, Age = ?, Weight = ?, Height = ?, Gender = ?, CalorieGoal = ? WHERE UserID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Age", user.Age);
                cmd.Parameters.AddWithValue("@Weight", user.Weight);
                cmd.Parameters.AddWithValue("@Height", user.Height);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@CalorieGoal", user.CalorieGoal);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    

    public static int GetUserCalorieGoal(int userID)
        {
            int goal = 0;

            string staticConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CourseWork.accdb";
            using (OleDbConnection conn = new OleDbConnection(staticConnectionString))
            {
                string sql = "SELECT CalorieGoal FROM tblUserInfo WHERE UserID = ?";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", userID);

                    conn.Open();

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        goal = Convert.ToInt32(result);
                    }
                }
            }

            return goal;
        }

        

        public static User Login(string username, string password)
        {
            User user = null;

            string staticConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CourseWork.accdb";
            using (OleDbConnection conn = new OleDbConnection(staticConnectionString))
            {
                string sql = "SELECT * FROM tblUserInfo WHERE UserName = ? AND Password = ?";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", username);
                    cmd.Parameters.AddWithValue("@p2", password);

                    conn.Open();

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new User();

                        user.UserID = Convert.ToInt32(reader["UserID"]);
                        user.UserName = reader["UserName"].ToString();
                        user.Role = reader["Role"].ToString();
                    }
                }
            }

            return user;
        }
    }
}
