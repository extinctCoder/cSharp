using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.DLL
{
    public partial class CashierPanel : UserControl
    {
        public CashierPanel()
        {
            InitializeComponent();
        }

        private void CashierPanel_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }
    }
}
