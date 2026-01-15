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
        FoodRepositary foodRepositary;
        public frmfoodlog()
        {
            InitializeComponent();
            foodRepositary = new FoodRepositary();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            AddButtons();
        }

        private void AddButtons()
        {
            var users = foodRepositary.GetFood();
            foreach (var item in users)
            {
                Button btn = new Button();
                btn.BackColor = Color.Lime;
                btn.ForeColor = Color.Black;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                btn.Tag = item.FoodID;
                btn.Text = item.FoodName;
                btn.Name = "btn_ ";
                btn.Click += Btn_Click; ;
                flpFood.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
