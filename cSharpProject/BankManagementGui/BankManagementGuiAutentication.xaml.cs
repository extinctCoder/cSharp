using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BankManagementGui
{
    /// <summary>
    /// Interaction logic for BankManagementGuiAutentication.xaml
    /// </summary>
    public partial class BankManagementGuiAutentication : UserControl
    {
        internal event EventHandler managerLoginCommand;

        internal event EventHandler secondOfficerLoginCommand;

        internal event EventHandler casherLoginCommand;

        public BankManagementGuiAutentication()
        {
            InitializeComponent();
            this.user_selection.Items.Add("Manager");
            this.user_selection.Items.Add("Second officer");
            this.user_selection.Items.Add("Casher");
        }

        private void username_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!String.IsNullOrEmpty(Convert.ToString(this.username_txt.Text)) && !String.IsNullOrEmpty(this.password_txt.Password) && (this.user_selection.SelectedIndex == 0 || this.user_selection.SelectedIndex == 1 || this.user_selection.SelectedIndex == 2))
                {
                    this.BankManagementGuiAutenticationVarification();
                }
                else
                {
                    this.optional_txt.Content = "please provide your access details.";
                }
            }
        }

        private void password_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!String.IsNullOrEmpty(Convert.ToString(this.username_txt.Text)) && !String.IsNullOrEmpty(this.password_txt.Password) && (this.user_selection.SelectedIndex == 0 || this.user_selection.SelectedIndex == 1 || this.user_selection.SelectedIndex == 2))
                {
                    this.BankManagementGuiAutenticationVarification();
                }
                else
                {
                    this.optional_txt.Content = "please provide your access details.";
                }
            }
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(this.username_txt.Text)) && !String.IsNullOrEmpty(this.password_txt.Password) && (this.user_selection.SelectedIndex == 0 || this.user_selection.SelectedIndex == 1 || this.user_selection.SelectedIndex == 2))
            {
                this.BankManagementGuiAutenticationVarification();
            }
            else
            {
                this.optional_txt.Content = "please provide your access details.";
            }
        }

        private void BankManagementGuiAutenticationVarification()
        {
            try
            {
                this.optional_txt.Content = "authorizing your access perimeters.";
                int userName = Convert.ToInt32(username_txt.Text);
                if (BankManagementGuiSrc.connectionTest())
                {
                    if (BankManagementGuiSrc.employeeVerification(userName, this.password_txt.Password, this.user_selection.SelectedIndex))
                    {
                        this.optional_txt.Content = "access granted.";
                        if (this.user_selection.SelectedIndex == 0)
                        {
                            if (this.managerLoginCommand != null)
                                this.managerLoginCommand(new object(), new EventArgs());
                        }
                        if (this.user_selection.SelectedIndex == 1)
                        {
                            if (this.secondOfficerLoginCommand != null)
                                this.secondOfficerLoginCommand(new object(), new EventArgs());
                        }
                        if (this.user_selection.SelectedIndex == 2)
                        {
                            if (this.casherLoginCommand != null)
                                this.casherLoginCommand(new object(), new EventArgs());
                        }
                    }
                    else
                    {
                        this.optional_txt.Content = "please provide your correct access details.";
                    }
                }
                else
                {
                    this.optional_txt.Content = "database is offline...:(";
                }
            }
            catch (Exception ex)
            {
                this.optional_txt.Content = "please provide your correct access details.";
            }
        }
    }
}