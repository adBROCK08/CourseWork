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
    public partial class frmfoodlog : Form
    {
        FoodRepositary foodRepositaryObj;
        
        private int UserID;
        //private DateTime logDate;
       

        public frmfoodlog(int UserID)
        {
            InitializeComponent();
            foodRepositaryObj = new FoodRepositary();
            this.UserID = UserID;
            //this.logDate = logDate;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void AddButtons()
        {
            var foodList = foodRepositaryObj.GetFood();
            foreach (var foodItem in foodList)
            {
                Button btn = new Button();
                btn.BackColor = Color.Lime;
                btn.ForeColor = Color.Black;
                btn.Size = new Size(70, 60);
                btn.Visible = true;
                btn.Tag = foodItem;
                btn.Text = foodItem.FoodName;
                btn.Name = "btn_ ";
                btn.Click += Btn_Click; ;
                flpFood.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Foods foodObj = (Foods)btn.Tag;
            

            int grams = Convert.ToInt32(txtGrams.Text);

            double calories = (foodObj.CaloriesPer100g / 100.0) * grams;

            FoodLog foodLogObj = new FoodLog();
            foodLogObj.FoodID = foodObj.FoodID; 
            foodLogObj.Grams = grams;
            foodLogObj.UserID = UserID;
            foodLogObj.LogDate = DateTime.Now.Date;

            
            FoodRepositary.AddFoodLog(foodLogObj);

            
            //double total = FoodRepositary.GetTotalCalories(userObj.UserID, DateTime.Now.Date);
            //lblTotalCalories.Text = total.ToString("0") + " kcal";
            progressCalories form = new progressCalories(UserID);
            form.Show();


        }

        private void frmfoodlog_Load(object sender, EventArgs e)
        {
            AddButtons();
            
        }

        private void btnAddFoods_Click(object sender, EventArgs e)
        {
            FoodForm FoodForm = new FoodForm();
            FoodForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            progressCalories form = new progressCalories(UserID);
            form.Show();
        }
    }
}
