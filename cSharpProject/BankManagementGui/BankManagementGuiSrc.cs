using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Controls;

namespace BankManagementGui
{
    public class BankManagementGuiSrc
    {
        private static string connectionString = "SERVER=localhost; PORT=3306; DATABASE=bank_ltd; UID=root; PASSWORD=; ";
        private static bool connectionStatus = false;

        public static bool connectionTest()
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();
                BankManagementGuiSrc.connectionStatus = true;
                return true;
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return false;
            }
        }

        public static bool userIdVerification(int tempId)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                MySqlCommand userNameAndPasswordSerch = new MySqlCommand("SELECT COUNT(*) FROM `bank_users` WHERE userId = " + tempId + ";", connection);
                connection.Open();
                if (Convert.ToString(userNameAndPasswordSerch.ExecuteScalar()) == "1")
                {
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static string userBalanceCheacker(int tempId)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand tempBalanceUpdate = new MySqlCommand("SELECT balance FROM `bank_users` WHERE userId = " + tempId + ";", connection);
                string tempBalance = tempBalanceUpdate.ExecuteScalar().ToString();
                connection.Close();
                BankManagementGuiSrc.connectionStatus = true;
                return tempBalance;
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
            }
            return null;
        }

        public static bool userBalanceUpdater(int tempId, double tempBalance, int employeeId, double transactionBalance, string transactionType)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand balanceUpdate = new MySqlCommand("UPDATE `bank_users` SET `balance` = '" + tempBalance + "' WHERE `bank_users`.`userId` = " + tempId + ";", connection);
                MySqlDataReader dataUpdater;
                dataUpdater = balanceUpdate.ExecuteReader();
                connection.Close();
                BankManagementGuiSrc.connectionStatus = true;
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return false;
            }

            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand balanceUpdate = new MySqlCommand("INSERT INTO `bank_transaction` (`userId`, `transactionType`, `Amount`, `employeeId`) VALUES('" + tempId + "', '" + transactionType + "', '" + transactionBalance + "', '" + employeeId + "');", connection);
                MySqlDataReader dataUpdater;
                dataUpdater = balanceUpdate.ExecuteReader();
                connection.Close();
                BankManagementGuiSrc.connectionStatus = true;
                return true;
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static bool employeeVerification(int username, string password, int userLevel)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                MySqlCommand userNameAndPasswordSerch = new MySqlCommand("SELECT COUNT(*) FROM `bank_employee` WHERE `employeeId` = " + username + " AND `accesPermission` = " + userLevel + " AND `password` LIKE '" + password + "';", connection);
                connection.Open();
                if (Convert.ToString(userNameAndPasswordSerch.ExecuteScalar()) == "1")
                {
                    BankManagementGuiSrc.connectionStatus = true;
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return false;
            }
            return false;
        }

        public static int addUser(string firstName, string middleName, string lastName, int accountType, int gender, DateTime dob, double balance, string password)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand adduserCommand = new MySqlCommand("INSERT INTO `bank_users` (`userId`, `firstName`, `middleName`, `lastName`, `password`, `gender`, `accountType`, `balance`, `openedTime`, `dateOfBirth`) VALUES (NULL, '" + firstName + "', '" + middleName + "', '" + lastName + "', '" + password + "', '" + gender + "', '" + accountType + "', '" + balance + "', CURRENT_TIMESTAMP, '" + dob.Year + "-" + dob.Month + "-" + dob.Date + "');" + "select last_insert_id();", connection);
                int id = Convert.ToInt32(adduserCommand.ExecuteScalar());
                MySqlDataReader dataUpdater;
                dataUpdater = adduserCommand.ExecuteReader();
                BankManagementGuiSrc.connectionStatus = true;
                return id;
                connection.Close();
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return -1;
            }
        }

        public static bool removeAccount(int tempUser)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand removeuserCommand = new MySqlCommand("DELETE FROM `bank_users` WHERE userId = " + tempUser + " ;", connection);
                MySqlDataReader dataUpdater;
                dataUpdater = removeuserCommand.ExecuteReader();
                connection.Close();
                BankManagementGuiSrc.connectionStatus = true;
                return true;
            }
            catch (Exception ex)
            {
                BankManagementGuiSrc.connectionStatus = false;
                return false;
            }
        }
    }
}