using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.DLL;
using MetroFramework.Forms;

namespace BankManagementSystem
{
    public partial class bankManagementSystem : MetroForm
    {
        public bankManagementSystem()
        {
            InitializeComponent();
            this.tableLayoutPanelContainer.Controls.Add(new ManagerPanel());
        }

        private void managerPanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableLayoutPanelContainer.Controls.Clear();
                this.tableLayoutPanelContainer.Controls.Add(new ManagerPanel());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void secondOfficerPanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableLayoutPanelContainer.Controls.Clear();
                this.tableLayoutPanelContainer.Controls.Add(new SecondOfficerPanel());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cashierPanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableLayoutPanelContainer.Controls.Clear();
                this.tableLayoutPanelContainer.Controls.Add(new CashierPanel());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
