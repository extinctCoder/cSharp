namespace BankManagementSystem.DLL
{
    partial class RemoveStaff
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
            this.stuffIdLabel = new System.Windows.Forms.Label();
            this.stuffIdTextBox = new System.Windows.Forms.TextBox();
            this.removeStuffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stuffIdLabel
            // 
            this.stuffIdLabel.AutoSize = true;
            this.stuffIdLabel.Location = new System.Drawing.Point(4, 0);
            this.stuffIdLabel.Name = "stuffIdLabel";
            this.stuffIdLabel.Size = new System.Drawing.Size(41, 13);
            this.stuffIdLabel.TabIndex = 0;
            this.stuffIdLabel.Text = "Staff Id";
            // 
            // stuffIdTextBox
            // 
            this.stuffIdTextBox.Location = new System.Drawing.Point(7, 21);
            this.stuffIdTextBox.Name = "stuffIdTextBox";
            this.stuffIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.stuffIdTextBox.TabIndex = 1;
            // 
            // removeStuffButton
            // 
            this.removeStuffButton.Location = new System.Drawing.Point(7, 48);
            this.removeStuffButton.Name = "removeStuffButton";
            this.removeStuffButton.Size = new System.Drawing.Size(75, 23);
            this.removeStuffButton.TabIndex = 2;
            this.removeStuffButton.Text = "remove stuff";
            this.removeStuffButton.UseVisualStyleBackColor = true;
            this.removeStuffButton.Click += new System.EventHandler(this.removeUserButtonClick);
            // 
            // RemoveStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeStuffButton);
            this.Controls.Add(this.stuffIdTextBox);
            this.Controls.Add(this.stuffIdLabel);
            this.Name = "RemoveStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stuffIdLabel;
        private System.Windows.Forms.TextBox stuffIdTextBox;
        private System.Windows.Forms.Button removeStuffButton;
    }
}
