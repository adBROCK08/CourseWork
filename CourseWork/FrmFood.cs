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
  
    public partial class FrmFood : Form
    {
        FoodRepositary foodRepositary;
        public FrmFood()
        {
            InitializeComponent();
            foodRepositary = new FoodRepositary();
        }

        private void FrmFood_Load(object sender, EventArgs e)
        {
            DisplayFoods();
        }

        private void DisplayFoods()
        {
            var foods = foodRepositary.GetFood();
            lstFoods.Items.Clear();
            foreach (var food in foods)
            {
                ListViewItem item = new ListViewItem(food.FoodID.ToString());
                item.SubItems.Add(food.FoodName.ToString());
                item.SubItems.Add(food.CaloriesPer100g.ToString());
                lstFoods.Items.Add(item);
            }
        }

        private void lstFoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditf_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.Show();
        }
    }
}
