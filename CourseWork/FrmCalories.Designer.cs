namespace CourseWork
{
    partial class FrmCalories
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalCalories = new System.Windows.Forms.TextBox();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Calories";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.Location = new System.Drawing.Point(353, 149);
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.Size = new System.Drawing.Size(122, 26);
            this.txtTotalCalories.TabIndex = 1;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Location = new System.Drawing.Point(353, 205);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(122, 26);
            this.txtRemaining.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remaining calories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(353, 292);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(148, 66);
            this.btnFood.TabIndex = 4;
            this.btnFood.Text = "Add Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // FrmCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.txtTotalCalories);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCalories";
            this.Text = "FrmCalories";
            this.Load += new System.EventHandler(this.FrmCalories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFood;
    }
}