namespace CourseWork
{
    partial class frmUserLog
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
            this.flpUser = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpUser
            // 
            this.flpUser.Location = new System.Drawing.Point(138, 81);
            this.flpUser.Name = "flpUser";
            this.flpUser.Size = new System.Drawing.Size(474, 236);
            this.flpUser.TabIndex = 0;
            this.flpUser.Paint += new System.Windows.Forms.PaintEventHandler(this.flpUser_Paint);
            // 
            // frmUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpUser);
            this.Name = "frmUserLog";
            this.Text = "frmUserLog";
            this.Load += new System.EventHandler(this.frmUserLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUser;
    }
}