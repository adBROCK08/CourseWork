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
    public partial class FoodForm : Form
    {
        FoodRepositary foodRepositary = new FoodRepositary();
        public FoodForm()
        {
            InitializeComponent();
        }


        private void FoodForm_Load(object sender, EventArgs e)
        {
            var food = foodRepositary.GetFood();
            cmbFoodID.DisplayMember = "FoodName";
            cmbFoodID.ValueMember = "FoodID";
            cmbFoodID.DataSource = food;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Foods food = foodRepositary.GetFilteredFoods(Convert.ToInt32(cmbFoodID.SelectedValue));
            if (food != null)
            {
                txtFoodName.Text = food.FoodName;
                txtCaloriesPer100g.Text = food.CaloriesPer100g.ToString();
            }
            else
            {
                MessageBox.Show("Student not found.");

            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            foodRepositary.AddFood(new Foods
            {
                FoodName = txtFoodName.Text,
                CaloriesPer100g = int.Parse(txtCaloriesPer100g.Text)

            });
        }

        private void btnDfood_Click(object sender, EventArgs e)
        {
            foodRepositary.DeleteFood(Convert.ToInt32(cmbFoodID.SelectedValue));

        }


    }
}
