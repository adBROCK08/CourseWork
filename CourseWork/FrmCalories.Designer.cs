namespace CourseWork
{
    partial class progressCalories
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarCalories = new System.Windows.Forms.ProgressBar();
            this.dgvFoodLog = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Calories";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.Location = new System.Drawing.Point(353, 82);
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.Size = new System.Drawing.Size(122, 26);
            this.txtTotalCalories.TabIndex = 1;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Location = new System.Drawing.Point(353, 196);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(122, 26);
            this.txtRemaining.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remaining calories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 66);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(353, 140);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(122, 26);
            this.txtGoal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calorie Goal";
            // 
            // BarCalories
            // 
            this.BarCalories.Location = new System.Drawing.Point(623, 80);
            this.BarCalories.Name = "BarCalories";
            this.BarCalories.Size = new System.Drawing.Size(271, 213);
            this.BarCalories.TabIndex = 9;
            // 
            // dgvFoodLog
            // 
            this.dgvFoodLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodLog.Location = new System.Drawing.Point(234, 372);
            this.dgvFoodLog.Name = "dgvFoodLog";
            this.dgvFoodLog.RowHeadersWidth = 62;
            this.dgvFoodLog.RowTemplate.Height = 28;
            this.dgvFoodLog.Size = new System.Drawing.Size(638, 296);
            this.dgvFoodLog.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Daily progress bar -";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(323, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 12;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(779, 47);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 20);
            this.lblWarning.TabIndex = 13;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(961, 140);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(151, 89);
            this.btnAddFood.TabIndex = 14;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // progressCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvFoodLog);
            this.Controls.Add(this.BarCalories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.txtTotalCalories);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "progressCalories";
            this.Text = "FrmCalories";
            this.Load += new System.EventHandler(this.FrmCalories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar BarCalories;
        private System.Windows.Forms.DataGridView dgvFoodLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnAddFood;
    }
}