namespace BankManagementSystem.DLL
{
    partial class CashierPanel
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.deposittabPage = new System.Windows.Forms.TabPage();
            this.depositPanel1 = new BankManagementSystem.DLL.DepositPanel();
            this.withdrawtabPage = new System.Windows.Forms.TabPage();
            this.withdrawPanel1 = new BankManagementSystem.DLL.WithdrawPanel();
            this.tabControl.SuspendLayout();
            this.deposittabPage.SuspendLayout();
            this.withdrawtabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.deposittabPage);
            this.tabControl.Controls.Add(this.withdrawtabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(150, 150);
            this.tabControl.TabIndex = 0;
            // 
            // deposittabPage
            // 
            this.deposittabPage.Controls.Add(this.depositPanel1);
            this.deposittabPage.Location = new System.Drawing.Point(4, 22);
            this.deposittabPage.Name = "deposittabPage";
            this.deposittabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deposittabPage.Size = new System.Drawing.Size(142, 124);
            this.deposittabPage.TabIndex = 0;
            this.deposittabPage.Text = "deposit";
            this.deposittabPage.UseVisualStyleBackColor = true;
            // 
            // depositPanel1
            // 
            this.depositPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depositPanel1.Location = new System.Drawing.Point(3, 3);
            this.depositPanel1.Name = "depositPanel1";
            this.depositPanel1.Size = new System.Drawing.Size(136, 118);
            this.depositPanel1.TabIndex = 0;
            // 
            // withdrawtabPage
            // 
            this.withdrawtabPage.Controls.Add(this.withdrawPanel1);
            this.withdrawtabPage.Location = new System.Drawing.Point(4, 22);
            this.withdrawtabPage.Name = "withdrawtabPage";
            this.withdrawtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.withdrawtabPage.Size = new System.Drawing.Size(142, 124);
            this.withdrawtabPage.TabIndex = 1;
            this.withdrawtabPage.Text = "withdraw";
            this.withdrawtabPage.UseVisualStyleBackColor = true;
            // 
            // withdrawPanel1
            // 
            this.withdrawPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.withdrawPanel1.Location = new System.Drawing.Point(3, 3);
            this.withdrawPanel1.Name = "withdrawPanel1";
            this.withdrawPanel1.Size = new System.Drawing.Size(136, 118);
            this.withdrawPanel1.TabIndex = 0;
            // 
            // ManagerPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tabControl);
            this.Name = "CashierPanel";
            this.Load += new System.EventHandler(this.CashierPanel_Load);
            this.tabControl.ResumeLayout(false);
            this.deposittabPage.ResumeLayout(false);
            this.withdrawtabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage deposittabPage;
        private DepositPanel depositPanel1;
        private System.Windows.Forms.TabPage withdrawtabPage;
        private WithdrawPanel withdrawPanel1;
    }
}
