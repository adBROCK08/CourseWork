namespace CourseWork
{
    partial class FrmPrivateUser
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
            this.txtConsumed = new System.Windows.Forms.TextBox();
            this.txtCalorieGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConsumed
            // 
            this.txtConsumed.Location = new System.Drawing.Point(314, 118);
            this.txtConsumed.Name = "txtConsumed";
            this.txtConsumed.Size = new System.Drawing.Size(100, 20);
            this.txtConsumed.TabIndex = 0;
            this.txtConsumed.TextChanged += new System.EventHandler(this.txtConsumed_TextChanged);
            // 
            // txtCalorieGoal
            // 
            this.txtCalorieGoal.Location = new System.Drawing.Point(314, 166);
            this.txtCalorieGoal.Name = "txtCalorieGoal";
            this.txtCalorieGoal.Size = new System.Drawing.Size(100, 20);
            this.txtCalorieGoal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALORIES CONSUMED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CALORIE GOAL";
            // 
            // FrmPrivateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalorieGoal);
            this.Controls.Add(this.txtConsumed);
            this.Name = "FrmPrivateUser";
            this.Text = "PrivateUser";
            this.Load += new System.EventHandler(this.PrivateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsumed;
        private System.Windows.Forms.TextBox txtCalorieGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}