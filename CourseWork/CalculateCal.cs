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
    public partial class CalculateCal : Form
    {
        private Foods foodObj;

        public CalculateCal()
        {
            InitializeComponent();
        }

        public CalculateCal(Foods foodObj, int grams)
        {
            this.foodObj = foodObj;
        }

        private void CalculateCal_Load(object sender, EventArgs e)
        {

        }
    }
}
