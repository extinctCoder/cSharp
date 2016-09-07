using System;
using System.Windows;

namespace BankManagementGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.container.Children.Clear();
            this.userAuthenticatorLoader();
        }

        private void userAuthenticatorLoader()
        {
            this.container.Children.Clear();
            BankManagementGuiAutentication user_authentication = new BankManagementGuiAutentication();
            this.container.Children.Add(user_authentication);
            user_authentication.managerLoginCommand += new EventHandler(managerLogin);
            user_authentication.secondOfficerLoginCommand += new EventHandler(secondOfficerLogin);
            user_authentication.casherLoginCommand += new EventHandler(casherLogin);
        }

        private void managerLoader()
        {
            this.container.Children.Clear();
            ManagerPanel manager_panel = new ManagerPanel();
            this.container.Children.Add(manager_panel);
            manager_panel.logoutCommand += Second_officer_panel_logoutCommand;
        }

        private void secondOfficerLoader()
        {
            this.container.Children.Clear();
            secondOfficerPanel second_officer_panel = new secondOfficerPanel();
            this.container.Children.Add(second_officer_panel);
            second_officer_panel.logoutCommand += Second_officer_panel_logoutCommand;
        }

        private void casherLoader()
        {
            this.container.Children.Clear();
            casherPanel casher_panel = new casherPanel();
            this.container.Children.Add(casher_panel);
            casher_panel.logoutCommand += Second_officer_panel_logoutCommand;
        }

        private void Second_officer_panel_logoutCommand(object sender, EventArgs e)
        {
            this.userAuthenticatorLoader();
        }

        private void managerLogin(object sender, EventArgs e)
        {
            this.managerLoader();
        }

        private void secondOfficerLogin(object sender, EventArgs e)
        {
            this.secondOfficerLoader();
        }

        private void casherLogin(object sender, EventArgs e)
        {
            this.casherLoader();
        }
    }
}