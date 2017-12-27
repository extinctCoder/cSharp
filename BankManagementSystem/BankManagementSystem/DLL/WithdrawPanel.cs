using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.BLL;

namespace BankManagementSystem.DLL
{
    public partial class WithdrawPanel : UserControl
    {
        public WithdrawPanel()
        {
            InitializeComponent();
        }

        private void withdrawButtonClick(object sender, EventArgs e)
        {
            try
            {
                dbHandler.withdraw(Convert.ToInt32(this.userIdTextBox.Text), Convert.ToDouble(this.amountTextBox.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
