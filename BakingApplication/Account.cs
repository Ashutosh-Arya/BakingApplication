using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class Account : IAccount
    {
        private string accountNo;
        private decimal totalBalance;
        private decimal withdrawalLimit;
        private decimal depositLimit;
        private Customer customer;
        private decimal requiredBalance;
        private Bank bankBranch;
        private Commons.AccountType accountType;

        public Account()
        {
            this.accountNo = String.Empty;
            this.totalBalance = 0.0M;
            this.withdrawalLimit = 5000;
            this.depositLimit = 0.0M;
            this.customer = new Customer();
            this.requiredBalance = 2000;
            bankBranch = new Bank();
        }

        public Account(string accountNo, decimal totalBalance, decimal withdrawalLimit, decimal depositLimit, Customer customer, decimal requiredBalance, Bank bankBranch)
        {
            AccountNo = accountNo;
            TotalBalance = totalBalance;
            WithdrawalLimit = withdrawalLimit;
            DepositLimit = depositLimit;
            Customer = customer;
            RequiredBalance = requiredBalance;
            BankBranch = bankBranch;
        }

        public string AccountNo
        {
            get { return accountNo; }
            set
            {
                if (Commons.CheckEmpty(value) && Commons.GetRegex(@"^[0-9]{10}$").IsMatch(value))
                {
                    this.accountNo = value;
                }
                else
                {
                    Console.WriteLine("Account number is not valid.");
                    accountNo = String.Empty;
                }
            }
        }
        public Commons.AccountType AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        public decimal TotalBalance
        {
            get { return totalBalance; }
            set 
            {
                if (value >= 0)
                {
                    this.totalBalance = value;
                }
                else
                {
                    Console.WriteLine("Invalid account balance "+ value);
                    totalBalance = 0.0M;
                }
            }
        }
        public decimal WithdrawalLimit
        {
            get
            { return withdrawalLimit; }
            set
            {
                if (value > 100 && value <= 5000)
                {
                    this.withdrawalLimit = value;
                }
                else
                {
                    Console.WriteLine("WithdrawalLimit " + value + " Not valid ");
                    withdrawalLimit = value;
                }
            }
        }

        
        public decimal DepositLimit
        {
            get { return depositLimit; }
            set
            {
                if (value > 0)
                {
                    this.depositLimit = value;
                }
                else
                {
                    Console.WriteLine("Deposit " + value + " not valid");
                }
            }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public decimal RequiredBalance
        {
            get { return requiredBalance; }
            set { requiredBalance = value; }
        }
        public Bank BankBranch
        {
            get { return bankBranch; }
            set { bankBranch = value; }
        }

        public override string ToString()
        {
            return "Account No: " + AccountNo +
                   "\nTotal Balance: " + TotalBalance +
                   "\nAccount Type: " + AccountType +
                   "\nCustomer Details: " + Customer.ToString() +
                   "\nBank: " + BankBranch.ToString() +
                   "\nRequired Balance: " + RequiredBalance;
        }
    }
}
