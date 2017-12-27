namespace BankManagementSystem.DLL
{
    partial class ViewAllUser
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanentaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomineenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.presentaddressDataGridViewTextBoxColumn,
            this.permanentaddressDataGridViewTextBoxColumn,
            this.postalcodeDataGridViewTextBoxColumn,
            this.contactnumberDataGridViewTextBoxColumn,
            this.nomineenameDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.userBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(682, 271);
            this.dataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presentaddressDataGridViewTextBoxColumn
            // 
            this.presentaddressDataGridViewTextBoxColumn.DataPropertyName = "presentaddress";
            this.presentaddressDataGridViewTextBoxColumn.HeaderText = "presentaddress";
            this.presentaddressDataGridViewTextBoxColumn.Name = "presentaddressDataGridViewTextBoxColumn";
            this.presentaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permanentaddressDataGridViewTextBoxColumn
            // 
            this.permanentaddressDataGridViewTextBoxColumn.DataPropertyName = "permanentaddress";
            this.permanentaddressDataGridViewTextBoxColumn.HeaderText = "permanentaddress";
            this.permanentaddressDataGridViewTextBoxColumn.Name = "permanentaddressDataGridViewTextBoxColumn";
            this.permanentaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalcodeDataGridViewTextBoxColumn
            // 
            this.postalcodeDataGridViewTextBoxColumn.DataPropertyName = "postalcode";
            this.postalcodeDataGridViewTextBoxColumn.HeaderText = "postalcode";
            this.postalcodeDataGridViewTextBoxColumn.Name = "postalcodeDataGridViewTextBoxColumn";
            this.postalcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contactnumber";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "contactnumber";
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            this.contactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomineenameDataGridViewTextBoxColumn
            // 
            this.nomineenameDataGridViewTextBoxColumn.DataPropertyName = "nomineename";
            this.nomineenameDataGridViewTextBoxColumn.HeaderText = "nomineename";
            this.nomineenameDataGridViewTextBoxColumn.Name = "nomineenameDataGridViewTextBoxColumn";
            this.nomineenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BankManagementSystem.DAL.user);
            // 
            // ViewAllUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Name = "ViewAllUser";
            this.Size = new System.Drawing.Size(682, 271);
            this.Load += new System.EventHandler(this.ViewAllUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanentaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomineenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}
