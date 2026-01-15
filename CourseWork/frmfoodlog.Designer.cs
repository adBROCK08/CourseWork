namespace CourseWork
{
    partial class frmfoodlog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpFood
            // 
            this.flpFood.Location = new System.Drawing.Point(180, 49);
            this.flpFood.Name = "flpFood";
            this.flpFood.Size = new System.Drawing.Size(477, 313);
            this.flpFood.TabIndex = 0;
            this.flpFood.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // frmfoodlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpFood);
            this.Name = "frmfoodlog";
            this.Text = "frmfoodlog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFood;
    }
}