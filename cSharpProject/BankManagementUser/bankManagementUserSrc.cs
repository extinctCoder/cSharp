using MySql.Data.MySqlClient;
using System;

namespace BankManagementUser
{
    internal static class BankManagementUserSrc
    {
        private static int userName = 0;
        private static String lastName = "";
        private static String password = "";
        private static Double balance = 0;
        private static string connectionString = "SERVER=localhost; PORT=3306; DATABASE=bank_ltd; UID=root; PASSWORD=; ";
        private static bool connectionStatus = false;

        public static string LastName
        {
            get
            {
                return BankManagementUserSrc.lastName;
            }
        }

        public static int UserName
        {
            get
            {
                return BankManagementUserSrc.userName;
            }
        }

        public static double Balance
        {
            get
            {
                return BankManagementUserSrc.balance;
            }
        }

        public static bool ConnectionStatus
        {
            get
            {
                return BankManagementUserSrc.connectionStatus;
            }
        }

        public static bool connectionTest()
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();
                BankManagementUserSrc.connectionStatus = true;
                return true;
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
        }

        public static void updateData(int userName, string password)
        {
            BankManagementUserSrc.userName = userName;
            BankManagementUserSrc.password = password;
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand nameUpdate = new MySqlCommand("SELECT lastName FROM `bank_users` WHERE userId = " + userName + " and password = '" + password + "'", connection);
                BankManagementUserSrc.lastName = nameUpdate.ExecuteScalar().ToString();
                MySqlCommand balanceUpdate = new MySqlCommand("SELECT balance FROM `bank_users` WHERE userId = " + userName + " and password = '" + password + "'", connection);
                BankManagementUserSrc.balance = Convert.ToDouble(balanceUpdate.ExecuteScalar().ToString());
                connection.Close();
                BankManagementUserSrc.connectionStatus = true;
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
            }
        }

        public static Boolean userAuthentication(int userName, string password)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                MySqlCommand userNameAndPasswordSerch = new MySqlCommand("SELECT COUNT(*) FROM `bank_users` WHERE userId = " + userName + " and password = '" + password + "'", connection);
                connection.Open();
                if (Convert.ToString(userNameAndPasswordSerch.ExecuteScalar()) == "1")
                {
                    BankManagementUserSrc.updateData(userName, password);
                    BankManagementUserSrc.connectionStatus = true;
                    return true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static Boolean updateBalance(int tempUserName, double tempBalance, double transactionBalance, string transactionType)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand balanceUpdate = new MySqlCommand("UPDATE `bank_users` SET `balance` = '" + tempBalance + "' WHERE `bank_users`.`userId` = " + tempUserName + ";", connection);
                MySqlDataReader dataUpdater;
                dataUpdater = balanceUpdate.ExecuteReader();
                connection.Close();
                BankManagementUserSrc.connectionStatus = true;
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand balanceUpdate = new MySqlCommand("INSERT INTO `bank_transaction` (`userId`, `transactionType`, `Amount`, `employeeId`) VALUES('" + tempUserName + "', '" + transactionType + "', '" + transactionBalance + "', '-1');", connection);
                MySqlDataReader dataUpdater;
                dataUpdater = balanceUpdate.ExecuteReader();
                connection.Close();
                BankManagementUserSrc.connectionStatus = true;
                return true;
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static Boolean deposit(int tempUserName, Double tempBalance)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand tempBalanceUpdate = new MySqlCommand("SELECT balance FROM `bank_users` WHERE userId = " + tempUserName + ";", connection);
                double tempMainBalance = Convert.ToDouble(tempBalanceUpdate.ExecuteScalar().ToString());
                if (tempBalance > 0)
                {
                    tempMainBalance += tempBalance;
                    BankManagementUserSrc.updateBalance(tempUserName, tempMainBalance, tempBalance, "deposit");
                    if (BankManagementUserSrc.userName == tempUserName)
                    {
                        BankManagementUserSrc.balance = tempMainBalance;
                    }
                    return true;
                }
                connection.Close();
                BankManagementUserSrc.connectionStatus = true;
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static Boolean withdraw(int tempUserName, Double tempBalance)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand tempBalanceUpdate = new MySqlCommand("SELECT balance FROM `bank_users` WHERE userId = " + tempUserName + ";", connection);
                double tempMainBalance = Convert.ToDouble(tempBalanceUpdate.ExecuteScalar().ToString());
                if (tempBalance <= tempMainBalance)
                {
                    tempMainBalance -= tempBalance;
                    BankManagementUserSrc.updateBalance(tempUserName, tempMainBalance, tempBalance, "Withdraw");
                    if (BankManagementUserSrc.userName == tempUserName)
                    {
                        BankManagementUserSrc.balance = tempMainBalance;
                    }
                    BankManagementUserSrc.connectionStatus = true;
                    return true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static Boolean transfer(int sender, int recever, Double tempBalance)
        {
            try
            {
                var reciverConnection = new MySqlConnection(connectionString);
                MySqlCommand reciverSerch = new MySqlCommand("SELECT COUNT(*) FROM `bank_users` WHERE userId = " + userName + " and password = '" + password + "'", reciverConnection);
                reciverConnection.Open();
                if (Convert.ToString(reciverSerch.ExecuteScalar()) == "1")
                {
                    if (BankManagementUserSrc.withdraw(sender, tempBalance) && BankManagementUserSrc.deposit(recever, tempBalance))
                    {
                        return true;
                    }
                }
                BankManagementUserSrc.connectionStatus = true;
                reciverConnection.Close();
            }
            catch (Exception ex)
            {
                BankManagementUserSrc.connectionStatus = false;
                return false;
            }
            return false;
        }
    }
}