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
    public partial class RemoveStaff : UserControl
    {
        public RemoveStaff()
        {
            InitializeComponent();
        }

        private void removeUserButtonClick(object sender, EventArgs e)
        {
            try
            {
                dbHandler.removeStuff(Convert.ToInt32(this.stuffIdTextBox.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
