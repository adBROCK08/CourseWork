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
    public partial class Form1 : Form
    {
        UserRepositary userRepositary;
        public Form1()
        {

            InitializeComponent();
            userRepositary = new UserRepositary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        public void DisplayUsers() 
        {
            var users = userRepositary.GetUser();
            lstVUser.Items.Clear(); 
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.UserID.ToString());
                item.SubItems.Add(user.UserName); 
                item.SubItems.Add(user.Age.ToString());
                item.SubItems.Add(user.Weight.ToString());
                item.SubItems.Add(user.Height.ToString());
                item.SubItems.Add(user.Gender);
                item.SubItems.Add(user.CalorieGoal.ToString());
                lstVUser.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            FoodForm FoodForm = new FoodForm();
            FoodForm.Show();
        }

        private void btnUserLog_Click(object sender, EventArgs e)
        {
            frmUserLog frmUserLog = new frmUserLog();
            frmUserLog.Show();
        }

        private void lstVUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
