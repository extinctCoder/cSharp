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
    /// Interaction logic for casherPanel.xaml
    /// </summary>
    public partial class casherPanel : UserControl
    {
        internal event EventHandler logoutCommand;

        private int employeeId;

        public casherPanel()
        {
            InitializeComponent();
        }

        public casherPanel(int employeeId) : this()
        {
            this.employeeId = employeeId;
        }

        private void deposit_Loaded(object sender, RoutedEventArgs e)
        {
            this.deposit_user_id.Clear();
            this.deposit_balance_txt.Clear();
            this.deposit_current_balance_txt.Clear();
            this.deposit_search_btn.Background = Brushes.LightGray;
            this.deposit_confirm_btn.Background = Brushes.LightGray;
            this.deposit_balance_txt.IsEnabled = false;
            this.deposit_confirm_btn.IsEnabled = false;
            this.deposit_user_id.Focus();
        }

        private void deposit_user_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.deposit_search_btn_Click(sender, e);
            }
        }

        private void deposit_search_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.deposit_user_id.Text))
            {
                try
                {
                    int tempId = Convert.ToInt32(this.deposit_user_id.Text);
                    if (BankManagementGuiSrc.userIdVerification(tempId))
                    {
                        this.deposit_current_balance_txt.Text = BankManagementGuiSrc.userBalanceCheacker(tempId);
                        this.deposit_search_btn.Background = Brushes.LightGray;
                        this.deposit_balance_txt.IsEnabled = true;
                        this.deposit_confirm_btn.IsEnabled = true;
                        this.deposit_balance_txt.Focus();
                    }
                    else
                    {
                        this.deposit_user_id.Clear();
                        this.deposit_search_btn.Background = Brushes.Red;
                    }
                }
                catch (Exception ex)
                {
                    this.deposit_user_id.Clear();
                    this.deposit_search_btn.Background = Brushes.Red;
                }
            }
            else
            {
                this.deposit_user_id.Clear();
                this.deposit_search_btn.Background = Brushes.Red;
            }
        }

        private void deposit_balance_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.deposit_confirm_btn_Click(sender, e);
            }
        }

        private void deposit_confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.deposit_balance_txt.Text))
            {
                try
                {
                    double tempBalance = Convert.ToDouble(this.deposit_balance_txt.Text);
                    double tempMainBalance = Convert.ToDouble(this.deposit_current_balance_txt.Text);
                    if (tempBalance > 0)
                    {
                        if (BankManagementGuiSrc.userBalanceUpdater(Convert.ToInt32(deposit_user_id.Text), tempMainBalance + tempBalance, this.employeeId, tempBalance, "deposit"))
                        {
                            MessageBoxResult result = MessageBox.Show("Deposit successful.", "Confirmation");
                            this.deposit_confirm_btn.Background = Brushes.LightGray;
                            this.deposit_Loaded(sender, e);
                        }
                        else
                        {
                            this.deposit_balance_txt.Clear();
                            this.deposit_confirm_btn.Background = Brushes.Red;
                        }
                    }
                    else
                    {
                        this.deposit_balance_txt.Clear();
                        this.deposit_confirm_btn.Background = Brushes.Red;
                    }
                }
                catch (Exception ex)
                {
                    this.deposit_balance_txt.Clear();
                    this.deposit_confirm_btn.Background = Brushes.Red;
                }
            }
            else
            {
                this.deposit_balance_txt.Clear();
                this.deposit_confirm_btn.Background = Brushes.Red;
            }
        }

        private void withdraw_Loaded(object sender, RoutedEventArgs e)
        {
            this.withdraw_user_id.Clear();
            this.withdraw_balance_txt.Clear();
            this.withdraw_current_balance_txt.Clear();
            this.deposit_search_btn.Background = Brushes.LightGray;
            this.deposit_confirm_btn.Background = Brushes.LightGray;
            this.withdraw_balance_txt.IsEnabled = false;
            this.withdraw_confirm_btn.IsEnabled = false;
            this.withdraw_user_id.Focus();
        }

        private void withdraw_user_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.withdraw_search_btn_Click(sender, e);
            }
        }

        private void withdraw_search_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.withdraw_user_id.Text))
            {
                try
                {
                    int tempId = Convert.ToInt32(this.withdraw_user_id.Text);
                    if (BankManagementGuiSrc.userIdVerification(tempId))
                    {
                        this.withdraw_current_balance_txt.Text = BankManagementGuiSrc.userBalanceCheacker(tempId);
                        this.withdraw_search_btn.Background = Brushes.LightGray;
                        this.withdraw_balance_txt.IsEnabled = true;
                        this.withdraw_confirm_btn.IsEnabled = true;
                        this.withdraw_balance_txt.Focus();
                    }
                    else
                    {
                        this.withdraw_user_id.Clear();
                        this.withdraw_search_btn.Background = Brushes.Red;
                    }
                }
                catch (Exception ex)
                {
                    this.withdraw_user_id.Clear();
                    this.withdraw_search_btn.Background = Brushes.Red;
                }
            }
            else
            {
                this.withdraw_user_id.Clear();
                this.withdraw_search_btn.Background = Brushes.Red;
            }
        }

        private void withdraw_balance_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.withdraw_confirm_btn_Click(sender, e);
            }
        }

        private void withdraw_confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.withdraw_balance_txt.Text))
            {
                try
                {
                    double tempBalance = Convert.ToDouble(this.withdraw_balance_txt.Text);
                    double tempMainBalance = Convert.ToDouble(this.withdraw_current_balance_txt.Text);
                    if (tempBalance <= tempMainBalance)
                    {
                        if (BankManagementGuiSrc.userBalanceUpdater(Convert.ToInt32(withdraw_user_id.Text), tempMainBalance - tempBalance, this.employeeId, tempBalance, "withdraw"))
                        {
                            MessageBoxResult result = MessageBox.Show("Withdraw successful.", "Confirmation");
                            this.withdraw_confirm_btn.Background = Brushes.LightGray;
                            this.withdraw_Loaded(sender, e);
                        }
                        else
                        {
                            this.withdraw_balance_txt.Clear();
                            this.withdraw_confirm_btn.Background = Brushes.Red;
                        }
                    }
                    else
                    {
                        this.withdraw_balance_txt.Clear();
                        this.withdraw_confirm_btn.Background = Brushes.Red;
                    }
                }
                catch (Exception ex)
                {
                    this.withdraw_balance_txt.Clear();
                    this.withdraw_confirm_btn.Background = Brushes.Red;
                }
            }
            else
            {
                this.withdraw_balance_txt.Clear();
                this.withdraw_confirm_btn.Background = Brushes.Red;
            }
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            if (this.logoutCommand != null)
                this.logoutCommand(new object(), new EventArgs());
        }
    }
}