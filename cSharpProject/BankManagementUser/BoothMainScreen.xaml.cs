using System;
using System.Windows;
using System.Windows.Controls;

namespace BankManagementUser
{
    /// <summary>
    /// Interaction logic for BoothMainScreen.xaml
    /// </summary>
    public partial class BoothMainScreen : UserControl
    {
        internal event EventHandler btn_11Cmnd;

        internal event EventHandler btn_17Cmnd;

        internal event EventHandler btn_31Cmnd;

        internal event EventHandler btn_37Cmnd;

        internal event EventHandler btn_51Cmnd;

        internal event EventHandler btn_57Cmnd;

        internal event EventHandler btn_71Cmnd;

        internal event EventHandler btn_77Cmnd;

        internal event EventHandler boothMainScreenLogoutCmnd;

        public BoothMainScreen()
        {
            InitializeComponent();
            this.lbl_11.Content = "lbl_11";
            this.lbl_15.Content = "lbl_15";
            this.lbl_31.Content = "lbl_31";
            this.lbl_35.Content = "lbl_35";
            this.lbl_51.Content = "lbl_51";
            this.lbl_55.Content = "lbl_55";
            this.lbl_71.Content = "lbl_71";
            this.lbl_75.Content = "lbl_75";
            this.booth_main_screen_gettings.Content = "booth_main_screen_gettings";
            this.booth_main_screen_username.Content = "booth_main_screen_username";
            this.logout_btn.Content = "logout_btn";
        }

        private void btn_11_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_11_Click ";
            if (this.btn_11Cmnd != null)
            {
                this.btn_11Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_17_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_17_Click";
            if (this.btn_17Cmnd != null)
            {
                this.btn_17Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_31_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_31_Click";
            if (this.btn_31Cmnd != null)
            {
                this.btn_31Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_37_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_37_Click";
            if (this.btn_37Cmnd != null)
            {
                this.btn_37Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_51_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_51_Click";
            if (this.btn_51Cmnd != null)
            {
                this.btn_51Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_57_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_57_Click";
            if (this.btn_57Cmnd != null)
            {
                this.btn_57Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_71_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_71_Click";
            if (this.btn_71Cmnd != null)
            {
                this.btn_71Cmnd(new object(), new EventArgs());
            }
        }

        private void btn_77_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "btn_77_Click";
            if (this.btn_77Cmnd != null)
            {
                this.btn_77Cmnd(new object(), new EventArgs());
            }
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            this.optional_console.Text = "logout_btn_Click";
            if (this.boothMainScreenLogoutCmnd != null)
            {
                this.boothMainScreenLogoutCmnd(new object(), new EventArgs());
            }
        }
    }
}