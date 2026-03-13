namespace CourseWork
{
    partial class Form1
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
            this.lstVUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUserLog = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVUser
            // 
            this.lstVUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstVUser.HideSelection = false;
            this.lstVUser.Location = new System.Drawing.Point(12, 12);
            this.lstVUser.Name = "lstVUser";
            this.lstVUser.Size = new System.Drawing.Size(573, 299);
            this.lstVUser.TabIndex = 0;
            this.lstVUser.UseCompatibleStateImageBehavior = false;
            this.lstVUser.View = System.Windows.Forms.View.Details;
            this.lstVUser.SelectedIndexChanged += new System.EventHandler(this.lstVUser_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UserID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UserName";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Weight (kg)";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Height (cm)";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gender";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Calorie goal";
            this.columnHeader7.Width = 79;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(63, 356);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 80);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUserLog
            // 
            this.btnUserLog.BackColor = System.Drawing.Color.White;
            this.btnUserLog.Location = new System.Drawing.Point(610, 96);
            this.btnUserLog.Name = "btnUserLog";
            this.btnUserLog.Size = new System.Drawing.Size(131, 154);
            this.btnUserLog.TabIndex = 2;
            this.btnUserLog.Text = "User Log";
            this.btnUserLog.UseVisualStyleBackColor = false;
            this.btnUserLog.Click += new System.EventHandler(this.btnUserLog_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(408, 356);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(110, 80);
            this.btnEditFood.TabIndex = 3;
            this.btnEditFood.Text = "Edit foods";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditFood);
            this.Controls.Add(this.btnUserLog);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstVUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUserLog;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

