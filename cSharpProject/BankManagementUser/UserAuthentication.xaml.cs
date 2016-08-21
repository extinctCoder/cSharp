using System;
using System.Windows;
using System.Windows.Controls;

namespace BankManagementUser
{
    /// <summary>
    /// Interaction logic for UserAuthentication.xaml
    /// </summary>

    public partial class UserAuthentication : UserControl
    {
        internal event EventHandler loginVarificationCmnd;

        public UserAuthentication()
        {
            InitializeComponent();
            this.username_lbl.Content = "username_lbl";
            this.password_lbl.Content = "password_lbl";
            this.login_btn.Content = "login_btn";
            this.wellcom_gettings_txt.Content = "wellcom_gettings_txt";
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(this.username_txt.Text)) && String.IsNullOrEmpty(this.password_txt.Password))
            {
                this.wellcom_gettings_txt.Content = "Please enter your user-name & password.";
            }
            else if (String.IsNullOrEmpty(Convert.ToString(this.username_txt.Text)))
            {
                this.wellcom_gettings_txt.Content = "Please enter your user-name.";
            }
            else if (String.IsNullOrEmpty(this.password_txt.Password))
            {
                this.wellcom_gettings_txt.Content = "Please enter your password.";
            }
            else
            {
                this.wellcom_gettings_txt.Content = "Authorizing your user-name & password.";
                if (this.loginVarificationCmnd != null)
                    this.loginVarificationCmnd(new object(), new EventArgs());
            }
        }
    }
}