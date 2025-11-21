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
                        user.Gender = reader.GetString(5);
                        Users.Add(user);
                    }
                }
            }
            return Users;
        }


        public void AddUser(User user)
        {
            string sql = "INSERT INTO tblUserInfo (UserName, Age, Weight, Height, Gender) VALUES (?, ?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Age", user.Age);
                cmd.Parameters.AddWithValue("@Weight", user.Weight);
                cmd.Parameters.AddWithValue("@Height", user.Height);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
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
                        };
                    }
                }
            }

            return user;
        }

        public void Delete(int userID)
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
            string sql = "UPDATE tblUserInfo SET UserName = ?, Age = ?, Weight = ?, Height = ?, Gender = ? WHERE UserID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Age", user.Age);
                cmd.Parameters.AddWithValue("@Weight", user.Weight);
                cmd.Parameters.AddWithValue("@Height", user.Height);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }

}
