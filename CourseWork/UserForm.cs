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
    public partial class FrmUser : Form
    {
        UserRepositary userRepositary;
        public FrmUser()
        {
            InitializeComponent();
            userRepositary = new UserRepositary();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var users = userRepositary.GetUser(); // var used but could be List<Student> for clarity
            cmbUserID.DisplayMember = "UserName";
            cmbUserID.ValueMember = "UserID";
            cmbUserID.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userRepositary.AddUser(new User
            {
                UserName = txtUserName.Text,
                Age = int.Parse(txtAge.Text),
                Weight = int.Parse(txtWeight.Text),
                Height = int.Parse(txtHeight.Text),
                Gender = txtGender.Text,
                CalorieGoal = int.Parse(txtCalorieGoal.Text)

            });
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = userRepositary.GetFilteredUser(Convert.ToInt32(cmbUserID.SelectedValue));
            if (user != null)
            {
                txtUserName.Text = user.UserName;
                txtAge.Text = user.Age.ToString();
                txtWeight.Text = user.Weight.ToString();
                txtHeight.Text = user.Height.ToString();
                txtGender.Text = user.Gender;
                txtCalorieGoal.Text = user.CalorieGoal.ToString();
            }
            else
            {
                MessageBox.Show("User not found.");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userRepositary.Delete(Convert.ToInt32(cmbUserID.SelectedValue));
            UpdateForms();
        }

        private void UpdateForms()
        {
            UserForm_Load(null, null);
            (Application.OpenForms["Form1"] as Form1).DisplayUsers(); 

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserID = Convert.ToInt32(cmbUserID.SelectedValue),
                UserName = txtUserName.Text,
                Age = int.Parse(txtAge.Text),
                Weight = int.Parse(txtWeight.Text),
                Height = int.Parse(txtHeight.Text),
                Gender = txtGender.Text,
                CalorieGoal = int.Parse(txtCalorieGoal.Text),
            };
            userRepositary.UpdateUser(user);
            UpdateForms();
        }
    }
}
