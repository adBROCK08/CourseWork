using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    
    public partial class FrmCalories : Form
    {
        FoodRepositary foodRepositary;
        private int userID;
        

        public FrmCalories()
        {
            InitializeComponent();
            
            foodRepositary = new FoodRepositary();
        }

        public FrmCalories(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            
        }


        private void FrmCalories_Load(object sender, EventArgs e)
        {
            double total = FoodRepositary.GetTotalCalories(userID, DateTime.Now.Date);

            txtTotalCalories.Text = total.ToString("0") + " kcal";

           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            
        }
    }
}
