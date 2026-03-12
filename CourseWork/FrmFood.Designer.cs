namespace CourseWork
{
    partial class FrmFood
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
            this.lstFoods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFoods
            // 
            this.lstFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstFoods.HideSelection = false;
            this.lstFoods.Location = new System.Drawing.Point(91, 12);
            this.lstFoods.Name = "lstFoods";
            this.lstFoods.Size = new System.Drawing.Size(592, 332);
            this.lstFoods.TabIndex = 0;
            this.lstFoods.UseCompatibleStateImageBehavior = false;
            this.lstFoods.View = System.Windows.Forms.View.Details;
            this.lstFoods.SelectedIndexChanged += new System.EventHandler(this.lstFoods_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FoodID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FoodName";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CaloriesPer100g";
            this.columnHeader3.Width = 113;
            // 
            // btnEditf
            // 
            this.btnEditf.Location = new System.Drawing.Point(325, 350);
            this.btnEditf.Name = "btnEditf";
            this.btnEditf.Size = new System.Drawing.Size(98, 64);
            this.btnEditf.TabIndex = 1;
            this.btnEditf.Text = "Edit Food";
            this.btnEditf.UseVisualStyleBackColor = true;
            this.btnEditf.Click += new System.EventHandler(this.btnEditf_Click);
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditf);
            this.Controls.Add(this.lstFoods);
            this.Name = "FrmFood";
            this.Text = "FrmFood";
            this.Load += new System.EventHandler(this.FrmFood_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFoods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEditf;
    }
}