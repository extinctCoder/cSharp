namespace BankManagementSystem.DLL
{
    partial class DepositPanel
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
            this.depositButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(4, 4);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(36, 13);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "userId";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(7, 21);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox.TabIndex = 1;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(7, 87);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButtonClick);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(7, 61);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(4, 44);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount";
            // 
            // DepositPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Name = "DepositPanel";
            this.Size = new System.Drawing.Size(398, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
    }
}
