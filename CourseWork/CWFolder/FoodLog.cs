using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class FoodLog
    {
        public int LogID { get; set; }
        public int FoodID { get; set; }
        public int Grams { get; set; }
        public DateTime LogDate { get; set; }
        public int UserID { get; set; }
    }
}
