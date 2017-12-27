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
using BankManagementSystem.DAL;

namespace BankManagementSystem.DLL
{
    public partial class AddStuff : UserControl
    {
        public AddStuff()
        {
            InitializeComponent();
        }

        private void addStuffButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler.addNewStuff(new stuff()
                {
                    name = this.nameTextBox.Text,
                    salary = this.salaryTextBox.Text,
                    rank = this.rankCombobox.SelectedIndex,
                    id = 0
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
