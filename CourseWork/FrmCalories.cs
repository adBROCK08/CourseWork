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
    
    public partial class progressCalories : Form
    {
        FoodRepositary foodRepositary;
        private int userID;
        

        public progressCalories()
        {
            InitializeComponent();
            
            foodRepositary = new FoodRepositary();
        }

        public progressCalories(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            
        }


        private void FrmCalories_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodLog.SelectedRows.Count > 0)
            {
                int LogID = Convert.ToInt32(
                    dgvFoodLog.SelectedRows[0].Cells["LogID"].Value
                );

                FoodRepositary.DeleteFoodLog(LogID);

                LoadData(); 
            }

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DateTime selectedDate = dtpDate.Value.Date;

            double total = FoodRepositary.GetTotalCalories(userID, selectedDate);
            int goal = UserRepositary.GetUserCalorieGoal(userID);
            double remaining = goal - total;

            //txtDate.Text = selectedDate.ToShortDateString();
            txtTotalCalories.Text = total.ToString("0") + " kcal";
            txtGoal.Text = goal.ToString() + " kcal";
            txtRemaining.Text = remaining.ToString("0") + " kcal left";

            BarCalories.Maximum = goal;
            BarCalories.Value = Math.Min((int)total, goal);

            dgvFoodLog.DataSource = FoodRepositary.GetFoodLogForDate(userID, selectedDate);

            
            if (total > goal)
            {
                lblWarning.Text = "Over calorie goal!";
                lblWarning.ForeColor = Color.Red;
            }
            else
            {
                lblWarning.Text = "Within goal";
                lblWarning.ForeColor = Color.Green;
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmfoodlog form = new frmfoodlog(userID);
            form.ShowDialog(); 

        }
    }
}
