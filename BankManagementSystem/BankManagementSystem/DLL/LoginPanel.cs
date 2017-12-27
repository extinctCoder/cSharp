using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MahApps.Metro;
using MetroFramework.Controls;

namespace BankManagementSystem.DLL
{
    public partial class LoginPanel : MetroUserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this.userNameTextBox != null && this.passwordTextBox != null)
                {
                    DepositPanel dp = new DepositPanel();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}
