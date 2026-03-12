namespace CourseWork
{
    partial class FoodForm
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
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtCaloriesPer100g = new System.Windows.Forms.TextBox();
            this.cmbFoodID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDfood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(326, 161);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 20);
            this.txtFoodName.TabIndex = 0;
            // 
            // txtCaloriesPer100g
            // 
            this.txtCaloriesPer100g.Location = new System.Drawing.Point(326, 211);
            this.txtCaloriesPer100g.Name = "txtCaloriesPer100g";
            this.txtCaloriesPer100g.Size = new System.Drawing.Size(100, 20);
            this.txtCaloriesPer100g.TabIndex = 1;
            // 
            // cmbFoodID
            // 
            this.cmbFoodID.FormattingEnabled = true;
            this.cmbFoodID.Location = new System.Drawing.Point(312, 115);
            this.cmbFoodID.Name = "cmbFoodID";
            this.cmbFoodID.Size = new System.Drawing.Size(121, 21);
            this.cmbFoodID.TabIndex = 2;
            this.cmbFoodID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Food name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calories per 100g";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(227, 297);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(104, 56);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Add food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDfood
            // 
            this.btnDfood.Location = new System.Drawing.Point(370, 297);
            this.btnDfood.Name = "btnDfood";
            this.btnDfood.Size = new System.Drawing.Size(98, 56);
            this.btnDfood.TabIndex = 7;
            this.btnDfood.Text = "Delete food";
            this.btnDfood.UseVisualStyleBackColor = true;
            this.btnDfood.Click += new System.EventHandler(this.btnDfood_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDfood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFoodID);
            this.Controls.Add(this.txtCaloriesPer100g);
            this.Controls.Add(this.txtFoodName);
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtCaloriesPer100g;
        private System.Windows.Forms.ComboBox cmbFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDfood;
    }
}