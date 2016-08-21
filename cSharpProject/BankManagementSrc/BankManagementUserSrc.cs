using System;

namespace BankManagementSrc
{
    public class BankManagementUserSrc
    {
        private int userName = 0;

        private String firstName = "";
        private String middleName = "";
        private String lastName = "";

        private String password = "";

        private Gender gender = Gender.Unknown;

        private AccountType accountType = AccountType.InValid;

        private Double balance = 0.00;

        public int UserName
        {
            get
            {
                return userName;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
        }

        public AccountType AccountType
        {
            get
            {
                return accountType;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public BankManagementUserSrc()
            : this(-1, "firstName", "middleName", "lastName", "password", Gender.Unknown, AccountType.InValid, 0.00)
        {
        }

        public BankManagementUserSrc(int userName, String firstName, String middleName, String lastName, String password, Gender gender, AccountType accountType, Double balance)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.password = password;
            this.gender = gender;
            this.accountType = accountType;
            this.balance = balance;
        }

        public Boolean userAuthentication(int userName, string password)
        {
            if (this.userName == userName && this.password.Equals(password))
            {
                return true;
            }
            return false;
        }

        public Boolean updateBalance(int userName, Double balance)
        {
            this.balance = balance;
            return true;
        }

        public Boolean deposit(int userName, Double tempBalance)
        {
            if (tempBalance > 0)
            {
                this.balance += tempBalance;
                return true;
            }
            return false;
        }

        public Boolean withdraw(int userName, Double tempBalance)
        {
            if (tempBalance < this.balance)
            {
                this.balance -= tempBalance;
                return true;
            }
            return false;
        }

        public Boolean transfer(int sender, int recever, Double tempBalance)
        {
            if (this.withdraw(sender, tempBalance))
            {
                return this.deposit(recever, tempBalance);
            }
            return false;
        }
    }
}