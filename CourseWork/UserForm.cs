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
    public partial class UserForm : Form
    {
        UserRepositary userRepositary;
        public UserForm()
        {
            InitializeComponent();
            userRepositary = new UserRepositary();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
