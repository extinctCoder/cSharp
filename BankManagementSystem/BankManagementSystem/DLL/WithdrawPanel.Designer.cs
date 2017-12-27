namespace BankManagementSystem.DLL
{
    partial class WithdrawPanel
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
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(3, 39);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(6, 56);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(6, 83);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButtonClick);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(6, 16);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox.TabIndex = 4;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(3, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(36, 13);
            this.userIdLabel.TabIndex = 3;
            this.userIdLabel.Text = "userId";
            // 
            // WithdrawPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Name = "WithdrawPanel";
            this.Size = new System.Drawing.Size(398, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label userIdLabel;
    }
}
