using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CourseWork
{
    public partial class frmUserLog : Form
    {
        UserRepositary userRepositary;
        public frmUserLog()
        {
            InitializeComponent();
            userRepositary = new UserRepositary();
        }

        private void flpUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUserLog_Load(object sender, EventArgs e)
        {
            AddButtons();
        }

        private void AddButtons()
        {  
            var users = userRepositary.GetUser();
            foreach (var item in users)
            {
                Button btn = new Button();
                btn.BackColor = Color.Lime;
                btn.ForeColor = Color.Black;
                btn.Size = new Size(100, 90);
                btn.Visible = true;
                //btn.Tag = item.UserID;
                btn.Tag = item;
                btn.Text = item.UserName;
                btn.Name = "btn_ ";
                btn.Click += Btn_Click; ;
                flpUser.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            User userObj =(User)btn.Tag;
            //FrmPrivateUser frmPrivateUser = new FrmPrivateUser(userObj);
            //frmPrivateUser.Show();
            frmfoodlog fl = new frmfoodlog(userObj.UserID);
            fl.Show();
        }
    }
}
