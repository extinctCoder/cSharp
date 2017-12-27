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
    public partial class AddUserPanel : UserControl
    {
        public AddUserPanel()
        {
            InitializeComponent();
        }

        private void addUserButtonClick(object sender, EventArgs e)
        {
            try
            {
                dbHandler.addNewUser(new user()
                {
                    amount = Convert.ToDouble(this.amountTextBox.Text),
                    firstname = this.firstNameTextBox.Text,
                    middlename = this.middleNameTextBox.Text,
                    lastname = this.lastNameTextBox.Text,
                    contactnumber = this.ContactNumberTextBox.Text,
                    gender = this.genderComboBox.SelectedIndex,
                    nationality = this.nationalityTextBox.Text,
                    nomineename = this.nomineeNameTextBox.Text,
                    permanentaddress = this.permanentAddressTextBox.Text,
                    presentaddress = this.presentAddressTextBox.Text,
                    postalcode = this.postalCodeTextBox.Text
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
