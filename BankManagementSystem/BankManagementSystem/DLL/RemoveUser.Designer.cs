namespace BankManagementSystem.DLL
{
    partial class RemoveUser
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
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(4, 4);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(41, 13);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "User Id";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(7, 21);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox.TabIndex = 1;
            // 
            // removeUserButton
            // 
            this.removeUserButton.Location = new System.Drawing.Point(7, 48);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(75, 23);
            this.removeUserButton.TabIndex = 2;
            this.removeUserButton.Text = "remove user";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButtonClick);
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Name = "RemoveUser";
            this.Size = new System.Drawing.Size(398, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Button removeUserButton;
    }
}
