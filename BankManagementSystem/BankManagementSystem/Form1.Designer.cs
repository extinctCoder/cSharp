namespace BankManagementSystem
{
    partial class bankManagementSystem
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
            this.tableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.managerPanelButton = new System.Windows.Forms.Button();
            this.secondOfficerPanelButton = new System.Windows.Forms.Button();
            this.cashierPanelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelButton
            // 
            this.tableLayoutPanelButton.AutoSize = true;
            this.tableLayoutPanelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelButton.ColumnCount = 3;
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.50094F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.50094F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanelButton.Controls.Add(this.managerPanelButton, 0, 0);
            this.tableLayoutPanelButton.Controls.Add(this.secondOfficerPanelButton, 1, 0);
            this.tableLayoutPanelButton.Controls.Add(this.cashierPanelButton, 2, 0);
            this.tableLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelButton.Location = new System.Drawing.Point(20, 551);
            this.tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            this.tableLayoutPanelButton.RowCount = 1;
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButton.Size = new System.Drawing.Size(760, 29);
            this.tableLayoutPanelButton.TabIndex = 0;
            this.tableLayoutPanelButton.UseWaitCursor = true;
            // 
            // managerPanelButton
            // 
            this.managerPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.managerPanelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.managerPanelButton.Location = new System.Drawing.Point(3, 3);
            this.managerPanelButton.Name = "managerPanelButton";
            this.managerPanelButton.Size = new System.Drawing.Size(279, 23);
            this.managerPanelButton.TabIndex = 0;
            this.managerPanelButton.Text = "ManagerPanel";
            this.managerPanelButton.UseVisualStyleBackColor = true;
            this.managerPanelButton.UseWaitCursor = true;
            this.managerPanelButton.Click += new System.EventHandler(this.managerPanelButton_Click);
            // 
            // secondOfficerPanelButton
            // 
            this.secondOfficerPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.secondOfficerPanelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.secondOfficerPanelButton.Location = new System.Drawing.Point(288, 3);
            this.secondOfficerPanelButton.Name = "secondOfficerPanelButton";
            this.secondOfficerPanelButton.Size = new System.Drawing.Size(279, 23);
            this.secondOfficerPanelButton.TabIndex = 1;
            this.secondOfficerPanelButton.Text = "SecondOfficerPanel";
            this.secondOfficerPanelButton.UseVisualStyleBackColor = true;
            this.secondOfficerPanelButton.UseWaitCursor = true;
            this.secondOfficerPanelButton.Click += new System.EventHandler(this.secondOfficerPanelButton_Click);
            // 
            // cashierPanelButton
            // 
            this.cashierPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cashierPanelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cashierPanelButton.Location = new System.Drawing.Point(573, 3);
            this.cashierPanelButton.Name = "cashierPanelButton";
            this.cashierPanelButton.Size = new System.Drawing.Size(184, 23);
            this.cashierPanelButton.TabIndex = 2;
            this.cashierPanelButton.Text = "CashierPanel";
            this.cashierPanelButton.UseVisualStyleBackColor = true;
            this.cashierPanelButton.UseWaitCursor = true;
            this.cashierPanelButton.Click += new System.EventHandler(this.cashierPanelButton_Click);
            // 
            // tableLayoutPanelContainer
            // 
            this.tableLayoutPanelContainer.AutoSize = true;
            this.tableLayoutPanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelContainer.ColumnCount = 1;
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContainer.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanelContainer.Name = "tableLayoutPanelContainer";
            this.tableLayoutPanelContainer.RowCount = 1;
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.Size = new System.Drawing.Size(760, 491);
            this.tableLayoutPanelContainer.TabIndex = 1;
            this.tableLayoutPanelContainer.UseWaitCursor = true;
            // 
            // bankManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanelContainer);
            this.Controls.Add(this.tableLayoutPanelButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "bankManagementSystem";
            this.Resizable = false;
            this.Text = "Bank Management System";
            this.UseWaitCursor = true;
            this.tableLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButton;
        private System.Windows.Forms.Button managerPanelButton;
        private System.Windows.Forms.Button secondOfficerPanelButton;
        private System.Windows.Forms.Button cashierPanelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer;
    }
}

