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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DisplayStudents() // needs to be public so can be accessed from FrmStudent
        {
            var students = studentRepositary.GetStudents();
            lstVStudents.Items.Clear(); // clear the ListView before adding new items
            foreach (var student in students)
            {
                ListViewItem item = new ListViewItem(student.StudentID.ToString());
                item.SubItems.Add(student.FirstName); // subitems are used to add additional columns in ListView
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.StudentDOB.ToShortDateString());
                lstVStudents.Items.Add(item);
            }
        }

    }
}
