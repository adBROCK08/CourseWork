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
    public partial class FrmPrivateUser : Form
    {
        UserRepositary userRepositary;
        User userObj;
        public FrmPrivateUser(User _userObj)
        {
            InitializeComponent();
            userRepositary = new UserRepositary();
            userObj = _userObj;
        }

        private void PrivateUser_Load(object sender, EventArgs e)
        {
            txtCalorieGoal.Text = userObj.CalorieGoal.ToString();
        }

        private void DisplayCalories()
        {
            
            
        }

        private void txtConsumed_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfoodlog_Click(object sender, EventArgs e)
        {
            //frmfoodlog frmfoodlog = new frmfoodlog();
            //frmfoodlog.Show();
        }

        private void txtCalorieGoal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
