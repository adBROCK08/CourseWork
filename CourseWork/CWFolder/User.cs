using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class User
    {
        public int UserID { get; set; } 
        public string UserName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
        public int CalorieGoal { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }





        public string FullName // used for combobox display 
        {
            get { return $"{UserName}"; }
        }
    }
}
