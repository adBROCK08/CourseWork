using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class UserRepositary
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CourseWork.accdb";


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
                        
                    }
                }
            }
            return Users;
        }

    }
}
