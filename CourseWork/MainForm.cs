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
    public partial class MainForm : Form
    {
        UserRepositary UserRepositary;
        public MainForm()
        {
            InitializeComponent();
            UserRepositary = new UserRepositary();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = UserRepositary.Login(txtUserName.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid login");
                return;
            }
            //Admin username is "Adrian Derecki" and password is "Adrian"

            if (user.Role == "User")
            {
                progressCalories form = new progressCalories(user.UserID);
                form.Show();
            }
            else if (user.Role == "Admin")
            {
                Form1 form = new Form1();
                form.Show();
            }

            this.Hide();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.UserName = txtNewUsername.Text;
            user.Age = Convert.ToInt32(txtAge.Text);
            user.Weight = Convert.ToInt32(txtWeight.Text);
            user.Height = Convert.ToInt32(txtHeight.Text);
            user.Gender = txtGender.Text;
            user.CalorieGoal = Convert.ToInt32(txtCalorieGoal.Text);
            user.Password = txtNewPassword.Text;
            user.Role = cmbRole.Text;

            UserRepositary.AddUser(user);

            MessageBox.Show("User created!");

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
