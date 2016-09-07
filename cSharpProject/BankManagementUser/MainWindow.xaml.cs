using System;
using System.Windows;

namespace BankManagementUser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ButtonStatus buttonStatus = ButtonStatus.NOT_DEFINED;
        private int reciver = -1;

        public MainWindow()
        {
            InitializeComponent();
            this.userAuthenticationVarificationHundler();
            this.user_authentication.loginVarificationCmnd += new EventHandler(userAuthenticationVarification);
            this.booth_main_screen.btn_11Cmnd += new EventHandler(Booth_main_screen_btn_11Cmnd);
            this.booth_main_screen.btn_17Cmnd += new EventHandler(Booth_main_screen_btn_17Cmnd);
            this.booth_main_screen.btn_31Cmnd += new EventHandler(Booth_main_screen_btn_31Cmnd);
            this.booth_main_screen.btn_37Cmnd += new EventHandler(Booth_main_screen_btn_37Cmnd);
            this.booth_main_screen.btn_51Cmnd += new EventHandler(Booth_main_screen_btn_51Cmnd);
            this.booth_main_screen.btn_57Cmnd += new EventHandler(Booth_main_screen_btn_57Cmnd);
            this.booth_main_screen.btn_71Cmnd += new EventHandler(Booth_main_screen_btn_71Cmnd);
            this.booth_main_screen.btn_77Cmnd += new EventHandler(Booth_main_screen_btn_77Cmnd);
            this.booth_main_screen.boothMainScreenLogoutCmnd += new EventHandler(boothMainScreenLogout);
            this.databaseOflineMode();
        }

        private void userAuthenticationVarificationHundler()
        {
            this.user_authentication.Visibility = Visibility.Visible;
            this.booth_main_screen.Visibility = Visibility.Hidden;
            this.booth_main_screen.main_console.IsEnabled = false;
            this.booth_main_screen_default_Loader();
            this.buttonStatus = ButtonStatus.NOT_DEFINED;
            this.booth_main_screen.main_console.Clear();
            this.booth_main_screen.optional_console.Text = "";
            user_authentication.username_lbl.Content = "USERNAME";
            user_authentication.password_lbl.Content = "PASSWORD";
            user_authentication.login_btn.Content = "LOGIN";
            user_authentication.wellcom_gettings_txt.Content = "please login to access your account ...! :P";
            this.user_authentication.username_txt.IsEnabled = true;
            this.user_authentication.password_txt.IsEnabled = true;
            this.user_authentication.login_btn.IsEnabled = true;
        }

        private void boothMainScreenHundler()
        {
            this.booth_main_screen.Visibility = Visibility.Visible;
            this.user_authentication.Visibility = Visibility.Hidden;
            this.booth_main_screen.main_console.IsEnabled = false;
            this.booth_main_screen_default_Loader();
            this.buttonStatus = ButtonStatus.NOT_DEFINED;
            this.booth_main_screen.main_console.Clear();
            this.booth_main_screen.optional_console.Text = "";
            this.booth_main_screen.booth_main_screen_username.Content = BankManagementUserSrc.LastName.ToUpper();
        }

        private void user_authentication_Loaded(object sender, RoutedEventArgs e)
        {
            user_authentication.username_lbl.Content = "USERNAME";
            user_authentication.password_lbl.Content = "PASSWORD";
            user_authentication.login_btn.Content = "LOGIN";
            user_authentication.wellcom_gettings_txt.Content = "please login to access your account ...! :P";
            this.databaseOflineMode();
        }

        private void booth_main_screen_Loaded(object sender, RoutedEventArgs e)
        {
            this.databaseOflineMode();
        }

        private void userAuthenticationVarification(object sender, EventArgs e)
        {
            this.userAuthenticationVarificationHundler();
            try
            {
                int tempUsernameTxt = Convert.ToInt32((this.user_authentication.username_txt.Text));
                if (BankManagementUserSrc.userAuthentication(tempUsernameTxt, this.user_authentication.password_txt.Password))
                {
                    this.boothMainScreenHundler();
                }
                else
                {
                    this.user_authentication.wellcom_gettings_txt.Content = "you entered a wrong user name or password ... :(";
                }
            }
            catch (Exception h)
            {
                this.user_authentication.wellcom_gettings_txt.Content = "please enter valid user name ... :(";
            }
            finally
            {
                this.user_authentication.username_txt.Clear();
                this.user_authentication.password_txt.Clear();
                this.databaseOflineMode();
            }
        }

        private void boothMainScreenLogout(object sender, EventArgs e)
        {
            this.userAuthenticationVarificationHundler();
            this.booth_main_screen_default_Loader();
            this.databaseOflineMode();
        }

        public void databaseOflineMode()
        {
            this.database_status.Content = BankManagementUserSrc.connectionTest();
            if (!BankManagementUserSrc.ConnectionStatus)
            {
                this.boothMainScreenHundler();
                this.booth_main_screen_default_Loader();
                this.userAuthenticationVarificationHundler();
                this.user_authentication.wellcom_gettings_txt.Content = "database is offline ...:(";
                this.user_authentication.username_txt.IsEnabled = false;
                this.user_authentication.password_txt.IsEnabled = false;
                this.user_authentication.login_btn.IsEnabled = false;
                this.database_status.Content = "offline";
                this.databse_reload_btn.IsEnabled = true;
            }
            else
            {
                if (this.user_authentication.username_txt.IsEnabled == false && this.user_authentication.password_txt.IsEnabled == false && this.user_authentication.login_btn.IsEnabled == false)
                {
                    this.userAuthenticationVarificationHundler();
                }
                this.databse_reload_btn.IsEnabled = false;
                this.database_status.Content = "online";
            }
        }

        private void databse_reload_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!BankManagementUserSrc.ConnectionStatus)
            {
                this.databaseOflineMode();
            }
            else
            {
                userAuthenticationVarificationHundler();
            }
        }
    }

    public partial class MainWindow : Window
    {
        private void booth_main_screen_null_txt_Loader()
        {
            this.booth_main_screen.lbl_11.Content = "";
            this.booth_main_screen.lbl_15.Content = "";
            this.booth_main_screen.lbl_31.Content = "";
            this.booth_main_screen.lbl_35.Content = "";
            this.booth_main_screen.lbl_51.Content = "";
            this.booth_main_screen.lbl_55.Content = "";
            this.booth_main_screen.lbl_71.Content = "";
            this.booth_main_screen.lbl_75.Content = "";
        }

        private void booth_main_screen_default_Loader()
        {
            this.buttonStatus = ButtonStatus.NOT_DEFINED;
            this.booth_main_screen.main_console.IsEnabled = false;
            this.booth_main_screen.main_console.Clear();
            this.booth_main_screen.optional_console.Text = "";

            this.booth_main_screen.btn_11.IsEnabled = true;
            this.booth_main_screen.btn_17.IsEnabled = true;
            this.booth_main_screen.btn_31.IsEnabled = true;
            this.booth_main_screen.btn_37.IsEnabled = true;
            this.booth_main_screen.btn_51.IsEnabled = true;
            this.booth_main_screen.btn_57.IsEnabled = true;
            this.booth_main_screen.btn_71.IsEnabled = true;
            this.booth_main_screen.btn_77.IsEnabled = true;

            this.booth_main_screen.lbl_11.Content = "withdrawal";
            this.booth_main_screen.lbl_15.Content = "fast_cash";
            this.booth_main_screen.lbl_31.Content = "balance_statment";
            this.booth_main_screen.lbl_35.Content = "password_change";
            this.booth_main_screen.lbl_51.Content = "fund_transfer";
            this.booth_main_screen.lbl_55.Content = "remittance";
            this.booth_main_screen.lbl_71.Content = "pre_paid_card";
            this.booth_main_screen.lbl_75.Content = "bills";
            this.booth_main_screen.booth_main_screen_gettings.Content = "Welcome back!";
            this.booth_main_screen.booth_main_screen_username.Content = BankManagementUserSrc.LastName.ToUpper();
            this.booth_main_screen.logout_btn.Content = "LOGOUT";
        }

        private void booth_main_screen_lbl_loader(String lbl_11, String lbl_15, String lbl_31, String lbl_35, String lbl_51, String lbl_55, String lbl_71, String lbl_75)
        {
            this.booth_main_screen.lbl_11.Content = lbl_11;
            this.booth_main_screen.lbl_15.Content = lbl_15;
            this.booth_main_screen.lbl_31.Content = lbl_31;
            this.booth_main_screen.lbl_35.Content = lbl_35;
            this.booth_main_screen.lbl_51.Content = lbl_51;
            this.booth_main_screen.lbl_55.Content = lbl_55;
            this.booth_main_screen.lbl_71.Content = lbl_71;
            this.booth_main_screen.lbl_75.Content = lbl_75;
        }

        private void booth_main_screen_btn_loader(Boolean btn_11, Boolean btn_17, Boolean btn_31, Boolean btn_37, Boolean btn_51, Boolean btn_57, Boolean btn_71, Boolean btn_77)
        {
            this.booth_main_screen.btn_11.IsEnabled = btn_11;
            this.booth_main_screen.btn_17.IsEnabled = btn_17;
            this.booth_main_screen.btn_31.IsEnabled = btn_31;
            this.booth_main_screen.btn_37.IsEnabled = btn_37;
            this.booth_main_screen.btn_51.IsEnabled = btn_51;
            this.booth_main_screen.btn_57.IsEnabled = btn_57;
            this.booth_main_screen.btn_71.IsEnabled = btn_71;
            this.booth_main_screen.btn_77.IsEnabled = btn_77;
            this.databaseOflineMode();
        }

        private void Booth_main_screen_btn_11Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen_null_txt_Loader();
                    this.buttonStatus = ButtonStatus.btn_11_1;
                    this.booth_main_screen.optional_console.Text = "please enter a valid amount";
                    this.booth_main_screen.main_console.IsEnabled = true;
                    this.booth_main_screen_lbl_loader("", "home", "", "clear", "", "withdraw with print", "", "withdraw without print");
                    this.booth_main_screen_btn_loader(false, true, false, true, false, true, false, true);
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_1:
                    this.buttonStatus = ButtonStatus.btn_17_2;
                    this.booth_main_screen_lbl_loader("", "", "", "clear", "", "withdraw with print", "", "withdraw without print");
                    this.booth_main_screen_btn_loader(false, false, false, true, false, true, false, true);
                    this.booth_main_screen.main_console.IsEnabled = false;
                    this.booth_main_screen.main_console.Text = "500";
                    this.booth_main_screen.optional_console.Text = "do you want to withdraw 500 tk.";
                    this.databaseOflineMode();
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_17Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen_null_txt_Loader();
                    this.buttonStatus = ButtonStatus.btn_17_1;
                    this.booth_main_screen_lbl_loader("500", "10000", "1000", "clear", "2000", "withdraw with print", "5000", "withdraw without print");
                    this.booth_main_screen_btn_loader(true, true, true, false, true, false, true, false);
                    this.booth_main_screen.optional_console.Text = "please chose your amount";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_11_1:

                    this.booth_main_screen_default_Loader();
                    this.booth_main_screen.optional_console.Text = "please chose another option.";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_1:
                    this.buttonStatus = ButtonStatus.btn_17_2;
                    this.booth_main_screen_lbl_loader("", "", "", "clear", "", "withdraw with print", "", "withdraw without print");
                    this.booth_main_screen_btn_loader(false, false, false, true, false, true, false, true);
                    this.booth_main_screen.main_console.IsEnabled = false;
                    this.booth_main_screen.main_console.Text = "10000";
                    this.booth_main_screen.optional_console.Text = "do you want to withdraw 10000 tk.";
                    this.databaseOflineMode();
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_31Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.buttonStatus = ButtonStatus.btn_31_1;
                    this.booth_main_screen_lbl_loader("", "", "", "check balance", "", "print current balance", "", "print mini statement");
                    this.booth_main_screen_btn_loader(false, false, false, true, false, true, false, true);
                    this.booth_main_screen.optional_console.Text = "please chose a option";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_1:
                    this.buttonStatus = ButtonStatus.btn_17_2;
                    this.booth_main_screen_lbl_loader("", "", "", "clear", "", "withdraw with print", "", "withdraw without print");
                    this.booth_main_screen_btn_loader(false, false, false, true, false, true, false, true);
                    this.booth_main_screen.main_console.IsEnabled = false;
                    this.booth_main_screen.main_console.Text = "1000";
                    this.booth_main_screen.optional_console.Text = "do you want to withdraw 1000 tk.";
                    this.databaseOflineMode();
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_37Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen.optional_console.Text = "system is not integrated";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_11_1:
                    this.buttonStatus = ButtonStatus.btn_11_1;
                    this.booth_main_screen.optional_console.Text = "please try again";
                    this.booth_main_screen.main_console.Clear();
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_31_1:
                    this.booth_main_screen_default_Loader();
                    this.booth_main_screen.optional_console.Text = "your current balance is : " + Convert.ToString(BankManagementUserSrc.Balance);
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_2:
                    this.buttonStatus = ButtonStatus.btn_17_1;
                    this.booth_main_screen.optional_console.Text = "please try again";
                    this.booth_main_screen.main_console.Clear();
                    this.booth_main_screen_lbl_loader("500", "10000", "1000", "clear", "2000", "withdraw with print", "5000", "withdraw without print");
                    this.booth_main_screen_btn_loader(true, true, true, false, true, false, true, false);
                    this.databaseOflineMode();
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_51Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen.main_console.IsEnabled = true;
                    this.buttonStatus = ButtonStatus.btn_51_1;
                    this.booth_main_screen_null_txt_Loader();
                    this.booth_main_screen_lbl_loader("", "", "", "", "", "clear", "", "enter amount");
                    this.booth_main_screen_btn_loader(false, false, false, false, false, true, false, true);
                    this.booth_main_screen.optional_console.Text = "please enter reviver account number";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_1:
                    this.buttonStatus = ButtonStatus.btn_17_2;
                    this.booth_main_screen_lbl_loader("", "", "", "clear", "", "withdraw with print", "", "withdraw without print");
                    this.booth_main_screen_btn_loader(false, false, false, true, false, true, false, true);
                    this.booth_main_screen.main_console.IsEnabled = false;
                    this.booth_main_screen.main_console.Text = "2000";
                    this.booth_main_screen.optional_console.Text = "do you want to withdraw 2000 tk.";
                    this.databaseOflineMode();
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_57Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen.optional_console.Text = "system is not integrated";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_11_1:
                    try
                    {
                        Double tempBalance = Convert.ToDouble((this.booth_main_screen.main_console.Text));
                        if (BankManagementUserSrc.withdraw(BankManagementUserSrc.UserName, tempBalance + 3.29))
                        {
                            this.booth_main_screen.optional_console.Text = "";
                            MessageBox.Show("your current balance is: " + BankManagementUserSrc.Balance, "withdrawal successful!");
                        }
                        else
                        {
                            this.booth_main_screen.optional_console.Text = "request cannot be completed due to low balance";
                        }
                    }
                    catch (Exception h)
                    {
                        this.booth_main_screen.optional_console.Text = "please enter a valid amount.";
                        this.buttonStatus = ButtonStatus.btn_11_1;
                        this.booth_main_screen.main_console.Clear();
                    }
                    finally
                    {
                        this.booth_main_screen.main_console.Clear();
                        this.databaseOflineMode();
                    }

                    break;

                case ButtonStatus.btn_31_1:
                    this.booth_main_screen_default_Loader();
                    if (BankManagementUserSrc.withdraw(BankManagementUserSrc.UserName, 3.29))
                    {
                        MessageBox.Show("your current balance is : " + Convert.ToString(BankManagementUserSrc.Balance), "balance status");
                        this.booth_main_screen.optional_console.Text = "please chose another option.";
                    }
                    else
                    {
                        this.booth_main_screen.optional_console.Text = "request cannot be completed due to low balance.";
                    }
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_51_1:
                    this.booth_main_screen.main_console.IsEnabled = true;
                    this.booth_main_screen.main_console.Clear();
                    this.buttonStatus = ButtonStatus.btn_51_1;
                    this.booth_main_screen_null_txt_Loader();
                    this.booth_main_screen_lbl_loader("", "", "", "", "", "clear", "", "enter amount");
                    this.booth_main_screen_btn_loader(false, false, false, false, false, true, false, true);
                    this.booth_main_screen.optional_console.Text = "please try again";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_2:

                    try
                    {
                        Double tempBalance = Convert.ToDouble((this.booth_main_screen.main_console.Text));
                        this.booth_main_screen_default_Loader();
                        if (BankManagementUserSrc.withdraw(BankManagementUserSrc.UserName, tempBalance + 3.29))
                        {
                            this.booth_main_screen.optional_console.Text = "";

                            MessageBox.Show("your current balance is: " + BankManagementUserSrc.Balance, "withdrawal successful!");
                        }
                        else
                        {
                            this.booth_main_screen.optional_console.Text = "request cannot be completed due to low balance";
                        }
                    }
                    catch (Exception h)
                    {
                        this.booth_main_screen.optional_console.Text = "please enter a valid amount.";
                        this.buttonStatus = ButtonStatus.btn_11_1;
                        this.booth_main_screen.main_console.Clear();
                    }
                    finally
                    {
                        this.databaseOflineMode();
                    }
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_71Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen.optional_console.Text = "system is not integrated";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_17_1:
                    this.buttonStatus = ButtonStatus.btn_17_2;
                    this.booth_main_screen_lbl_loader("", "", "", "clear", "", "withdraw with print", "", "withdraw without print");
                    this.booth_main_screen_btn_loader(false, false, false, true, false, true, false, true);
                    this.booth_main_screen.main_console.IsEnabled = false;
                    this.booth_main_screen.main_console.Text = "5000";
                    this.booth_main_screen.optional_console.Text = "do you want to withdraw 5000 tk.";
                    this.databaseOflineMode();
                    break;

                default:
                    break;
            }
        }

        private void Booth_main_screen_btn_77Cmnd(object sender, EventArgs e)
        {
            switch (this.buttonStatus)
            {
                case ButtonStatus.NOT_DEFINED:
                    this.booth_main_screen.optional_console.Text = "system is not integrated";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_11_1:
                    try
                    {
                        Double tempBalance = Convert.ToDouble((this.booth_main_screen.main_console.Text));

                        if (BankManagementUserSrc.withdraw(BankManagementUserSrc.UserName, tempBalance))
                        {
                            this.booth_main_screen.optional_console.Text = "withdrawal successful! your current balance is: " + BankManagementUserSrc.Balance;
                        }
                        else
                        {
                            this.booth_main_screen.optional_console.Text = "request cannot be completed due to low balance";
                        }
                    }
                    catch (Exception h)
                    {
                        this.booth_main_screen.optional_console.Text = "please enter a valid amount.";
                        this.buttonStatus = ButtonStatus.btn_11_1;
                        this.booth_main_screen.main_console.Clear();
                    }
                    finally
                    {
                        this.booth_main_screen.main_console.Clear();
                        this.databaseOflineMode();
                    }
                    break;

                case ButtonStatus.btn_31_1:
                    this.booth_main_screen_default_Loader();
                    this.booth_main_screen.optional_console.Text = "system is not integrated";
                    this.databaseOflineMode();
                    break;

                case ButtonStatus.btn_51_1:
                    try
                    {
                        this.reciver = Convert.ToInt32(this.booth_main_screen.main_console.Text);
                        this.booth_main_screen.optional_console.Text = "now please enter amount";
                        this.booth_main_screen.main_console.IsEnabled = true;
                        this.booth_main_screen.main_console.Clear();
                        this.booth_main_screen_null_txt_Loader();
                        this.booth_main_screen_lbl_loader("", "", "", "", "", "clear", "", "send");
                        this.booth_main_screen_btn_loader(false, false, false, false, false, true, false, true);
                        this.buttonStatus = ButtonStatus.btn_51_2;
                    }
                    catch (Exception h)
                    {
                        this.booth_main_screen.optional_console.Text = "please enter a valid account number.";
                        this.buttonStatus = ButtonStatus.btn_51_1;
                        this.booth_main_screen.main_console.Clear();
                    }
                    finally
                    {
                        this.booth_main_screen.main_console.Clear();
                        this.databaseOflineMode();
                    }
                    break;

                case ButtonStatus.btn_51_2:
                    try
                    {
                        Double tempBalance = Convert.ToDouble((this.booth_main_screen.main_console.Text));
                        int tempReciver = Convert.ToInt32(this.reciver);
                        this.booth_main_screen_default_Loader();
                        if (BankManagementUserSrc.transfer(BankManagementUserSrc.UserName, tempReciver, tempBalance))
                        {
                            this.booth_main_screen.optional_console.Text = "transfer successful! your current balance is: " + BankManagementUserSrc.Balance;
                        }
                        else
                        {
                            this.booth_main_screen.optional_console.Text = "request cannot be completed due to low balance";
                        }
                    }
                    catch (Exception h)
                    {
                        this.booth_main_screen.optional_console.Text = "please enter a valid amount.";
                        this.buttonStatus = ButtonStatus.NOT_DEFINED;
                        this.booth_main_screen.main_console.Clear();
                        this.buttonStatus = ButtonStatus.btn_51_2;
                    }
                    finally
                    {
                        this.booth_main_screen.main_console.Clear();
                        this.reciver = -1;
                        this.databaseOflineMode();
                    }
                    break;

                case ButtonStatus.btn_17_2:
                    try
                    {
                        Double tempBalance = Convert.ToDouble((this.booth_main_screen.main_console.Text));
                        this.booth_main_screen_default_Loader();
                        if (BankManagementUserSrc.withdraw(BankManagementUserSrc.UserName, tempBalance))
                        {
                            this.booth_main_screen.optional_console.Text = "withdrawal successful! your current balance is: " + BankManagementUserSrc.Balance;
                        }
                        else
                        {
                            this.booth_main_screen.optional_console.Text = "request cannot be completed due to low balance";
                        }
                    }
                    catch (Exception h)
                    {
                        this.booth_main_screen.optional_console.Text = "please enter a valid amount.";
                        this.buttonStatus = ButtonStatus.btn_11_1;
                        this.booth_main_screen.main_console.Clear();
                    }
                    finally
                    {
                        this.databaseOflineMode();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}