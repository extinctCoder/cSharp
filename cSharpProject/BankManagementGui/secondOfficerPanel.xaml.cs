using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankManagementGui
{
    /// <summary>
    /// Interaction logic for secondOfficerPanel.xaml
    /// </summary>
    public partial class secondOfficerPanel : UserControl
    {
        internal event EventHandler logoutCommand;

        public secondOfficerPanel()
        {
            InitializeComponent();
        }

        private void add_account_Loaded(object sender, RoutedEventArgs e)
        {
            this.account_type_combo.Items.Add("Current");
            this.account_type_combo.Items.Add("Savings");
            this.gender_combo.Items.Add("Male");
            this.gender_combo.Items.Add("Female");
            this.gender_combo.Items.Add("Unknown");
        }

        private void remove_account_Loaded(object sender, RoutedEventArgs e)
        {
            this.remove_confirm_account_btn.IsEnabled = false;
        }

        private void balance_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.confirm_btn_Click(sender, e);
            }
        }

        private void remove_user_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.remove_account_btn_Click(sender, e);
            }
        }

        private bool nullConfirmTextCheacker()
        {
            if (String.IsNullOrEmpty(this.first_nam_txt.Text) && String.IsNullOrEmpty(this.middle_name_txt.Text) && String.IsNullOrEmpty(this.last_name_txt.Text) && this.account_type_combo.SelectedIndex == -1 && this.gender_combo.SelectedIndex == -1 && this.dob_txt.SelectedDate == null)
            {
                this.confirm_btn.Background = Brushes.Red;
                return true;
            }
            this.confirm_btn.Background = Brushes.LightGray;
            return false;
        }

        private void confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!this.nullConfirmTextCheacker())
            {
                try
                {
                    double balance = Convert.ToDouble(this.balance_txt.Text);
                    string password = this.CreatePassword(4);
                    int newUser = BankManagementGuiSrc.addUser(this.first_nam_txt.Text, this.middle_name_txt.Text, this.last_name_txt.Text, this.account_type_combo.SelectedIndex, this.gender_combo.SelectedIndex, this.dob_txt.DisplayDate, balance, password);
                    if (newUser >= -1 && BankManagementGuiSrc.connectionTest())
                    {
                        MessageBox.Show("New Account Added ...!!!!\nUser Id : " + newUser + "\nPassword is : " + password, "Confirmation");
                        this.confirm_btn.Background = Brushes.LightGray;
                    }
                    else
                    {
                        this.confirm_btn.Background = Brushes.Red;
                    }
                }
                catch (Exception ex)
                {
                    this.confirm_btn.Background = Brushes.Red;
                }
            }
            else
            {
                this.confirm_btn.Background = Brushes.Red;
            }
        }

        private void remove_account_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.remove_user_id.Text))
            {
                this.remove_account_btn.Background = Brushes.LightGray;
                try
                {
                    int tempUser = Convert.ToInt32(this.remove_user_id.Text);
                    if (BankManagementGuiSrc.userIdVerification(tempUser))
                    {
                        this.remove_account_btn.Background = Brushes.LightGray;
                        this.remove_user_balance_txt.Text = BankManagementGuiSrc.userBalanceCheacker(tempUser);
                        this.remove_confirm_account_btn.IsEnabled = true;
                    }
                    else
                    {
                        this.remove_account_btn.Background = Brushes.Red;
                        this.remove_user_id.Clear();
                    }
                }
                catch (Exception ex)
                {
                    this.remove_account_btn.Background = Brushes.Red;
                    this.remove_user_id.Clear();
                }
            }
            else
            {
                this.remove_account_btn.Background = Brushes.Red;
                this.remove_user_id.Clear();
            }
        }

        private void remove_confirm_account_btn_Click(object sender, RoutedEventArgs e)
        {
            if (BankManagementGuiSrc.removeAccount(Convert.ToInt32(this.remove_user_id.Text)))
            {
                MessageBox.Show("Account Removed\nAccount Number : " + this.remove_user_id.Text, "Confirmation");
            }
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            if (this.logoutCommand != null)
                this.logoutCommand(new object(), new EventArgs());
        }

        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}