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
    public partial class PrivateUser : Form
    {
        UserRepositary userRepositary;
        public PrivateUser()
        {
            InitializeComponent();
            userRepositary = new UserRepositary();
        }

        private void PrivateUser_Load(object sender, EventArgs e)
        {
            DisplayCalories();
        }

        private void DisplayCalories()
        {
            
        }

        private void txtConsumed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
