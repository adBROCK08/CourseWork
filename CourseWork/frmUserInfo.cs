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
    public partial class frmUserInfo : Form
    {
        UserRepositary userRepositary;
        public frmUserInfo()
        {
            InitializeComponent();
            userRepositary = new UserRepositary();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            DisplayUser();
        }

        private void DisplayUser()
        {
            throw new NotImplementedException();
        }
    }
}
