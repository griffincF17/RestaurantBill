namespace RestaurantBill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AppetizerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DessertComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BeverageComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ClearBillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appetizer:";
            // 
            // AppetizerComboBox
            // 
            this.AppetizerComboBox.FormattingEnabled = true;
            this.AppetizerComboBox.Items.AddRange(new object[] {
            "Buffalo Wings ($5.95)",
            "Buffalo Fingers ($6.95)",
            "Potato Skins ($8.95)",
            "Nachos ($8.95)",
            "Mushroom Caps ($10.95)",
            "Shrimp Cocktail ($12.95)",
            "Chips and Salsa ($6.95)"});
            this.AppetizerComboBox.Location = new System.Drawing.Point(112, 6);
            this.AppetizerComboBox.Name = "AppetizerComboBox";
            this.AppetizerComboBox.Size = new System.Drawing.Size(222, 28);
            this.AppetizerComboBox.TabIndex = 1;
            this.AppetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.AppetizerComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Course:";
            // 
            // MainCourseComboBox
            // 
            this.MainCourseComboBox.FormattingEnabled = true;
            this.MainCourseComboBox.Items.AddRange(new object[] {
            "Seafood Alfredo ($15.95)",
            "Chicken Alfredo ($13.95)",
            "Chicken Picatta ($13.95)",
            "Turkey Club ($11.95)",
            "Lobster Pie ($19.95)",
            "Prime Rib ($20.95)",
            "Shrimp Scampi ($18.95)",
            "Turkey Dinner ($13.95)",
            "Stuffed Chicken ($14.95)"});
            this.MainCourseComboBox.Location = new System.Drawing.Point(112, 37);
            this.MainCourseComboBox.Name = "MainCourseComboBox";
            this.MainCourseComboBox.Size = new System.Drawing.Size(222, 28);
            this.MainCourseComboBox.TabIndex = 3;
            this.MainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.MainCourseComboBox_SelectedIndexChanged);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dessert:";
            // 
            // DessertComboBox
            // 
            this.DessertComboBox.FormattingEnabled = true;
            this.DessertComboBox.Items.AddRange(new object[] {
            "Apple Pie ($5.95)",
            "Sundae ($3.95)",
            "Carrot Cake ($5.95)",
            "Mud Pie ($4.95)",
            "Apple Crisp ($5.95)"});
            this.DessertComboBox.Location = new System.Drawing.Point(112, 70);
            this.DessertComboBox.Name = "DessertComboBox";
            this.DessertComboBox.Size = new System.Drawing.Size(222, 28);
            this.DessertComboBox.TabIndex = 5;
            this.DessertComboBox.SelectedIndexChanged += new System.EventHandler(this.DessertComboBox_SelectedIndexChanged);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beverage:";
            // 
            // BeverageComboBox
            // 
            this.BeverageComboBox.FormattingEnabled = true;
            this.BeverageComboBox.Items.AddRange(new object[] {
            "Soda ($1.95)",
            "Tea ($1.50)",
            "Coffee ($1.25)",
            "Mineral Water ($2.95)",
            "Juice ($2.50)",
            "Milk ($1.50)"});
            this.BeverageComboBox.Location = new System.Drawing.Point(112, 102);
            this.BeverageComboBox.Name = "BeverageComboBox";
            this.BeverageComboBox.Size = new System.Drawing.Size(222, 28);
            this.BeverageComboBox.TabIndex = 7;
            this.BeverageComboBox.SelectedIndexChanged += new System.EventHandler(this.BeverageComboBox_SelectedIndexChanged);

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtotal:";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(221, 150);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(133, 27);
            this.SubtotalTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tax:";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(221, 183);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(133, 27);
            this.TaxTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(221, 216);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(133, 27);
            this.TotalTextBox.TabIndex = 13;
            // 
            // ClearBillButton
            // 
            this.ClearBillButton.Location = new System.Drawing.Point(12, 177);
            this.ClearBillButton.Name = "ClearBillButton";
            this.ClearBillButton.Size = new System.Drawing.Size(118, 46);
            this.ClearBillButton.TabIndex = 14;
            this.ClearBillButton.Text = "Clear Bill";
            this.ClearBillButton.UseVisualStyleBackColor = true;
            this.ClearBillButton.Click += new System.EventHandler(this.ClearBillButton_Click);


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 255);
            this.Controls.Add(this.ClearBillButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BeverageComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DessertComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainCourseComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppetizerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Restaurant Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox AppetizerComboBox;
        private Label label2;
        private ComboBox MainCourseComboBox;
        private Label label3;
        private ComboBox DessertComboBox;
        private Label label4;
        private ComboBox BeverageComboBox;
        private Label label5;
        private TextBox SubtotalTextBox;
        private Label label6;
        private TextBox TaxTextBox;
        private Label label7;
        private TextBox TotalTextBox;
        private Button ClearBillButton;
    }
}