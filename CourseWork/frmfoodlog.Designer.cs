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
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.lblGrams = new System.Windows.Forms.Label();
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
            // txtGrams
            // 
            this.txtGrams.Location = new System.Drawing.Point(684, 49);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(100, 20);
            this.txtGrams.TabIndex = 1;
            // 
            // lblGrams
            // 
            this.lblGrams.AutoSize = true;
            this.lblGrams.Location = new System.Drawing.Point(684, 30);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(37, 13);
            this.lblGrams.TabIndex = 2;
            this.lblGrams.Text = "Grams";
            // 
            // frmfoodlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrams);
            this.Controls.Add(this.txtGrams);
            this.Controls.Add(this.flpFood);
            this.Name = "frmfoodlog";
            this.Text = "frmfoodlog";
            this.Load += new System.EventHandler(this.frmfoodlog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFood;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.Label lblGrams;
    }
}