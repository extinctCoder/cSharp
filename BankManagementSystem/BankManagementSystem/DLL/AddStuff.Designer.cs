namespace BankManagementSystem.DLL
{
    partial class AddStuff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankCombobox = new System.Windows.Forms.ComboBox();
            this.addStuffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(7, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(7, 61);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 3;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(4, 44);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 2;
            this.salaryLabel.Text = "Salary";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(4, 84);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rankLabel.Size = new System.Drawing.Size(33, 13);
            this.rankLabel.TabIndex = 4;
            this.rankLabel.Text = "Rank";
            // 
            // rankCombobox
            // 
            this.rankCombobox.FormattingEnabled = true;
            this.rankCombobox.Items.AddRange(new object[] {
            "Manager",
            "Second Officer",
            "Cashier"});
            this.rankCombobox.Location = new System.Drawing.Point(7, 101);
            this.rankCombobox.Name = "rankCombobox";
            this.rankCombobox.Size = new System.Drawing.Size(121, 21);
            this.rankCombobox.TabIndex = 5;
            // 
            // addStuffButton
            // 
            this.addStuffButton.Location = new System.Drawing.Point(7, 129);
            this.addStuffButton.Name = "addStuffButton";
            this.addStuffButton.Size = new System.Drawing.Size(75, 23);
            this.addStuffButton.TabIndex = 6;
            this.addStuffButton.Text = "add stuff";
            this.addStuffButton.UseVisualStyleBackColor = true;
            this.addStuffButton.Click += new System.EventHandler(this.addStuffButton_Click);
            // 
            // AddStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addStuffButton);
            this.Controls.Add(this.rankCombobox);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddStuff";
            this.Size = new System.Drawing.Size(398, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.ComboBox rankCombobox;
        private System.Windows.Forms.Button addStuffButton;
    }
}
