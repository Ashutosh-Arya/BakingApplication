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
            this.withdrawalLimit = 0.0M;
            this.depositLimit = 0.0M;
            this.customer = new Customer();
            this.requiredBalance = 0.0M;
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

        public virtual string AccountNo
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
                if (value >= 0.0M)
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
            set { withdrawalLimit = value; }
          
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
            set {  requiredBalance = value; }
        }
        public Bank BankBranch
        {
            get { return bankBranch; }
            set { bankBranch = value; }
        }

        public override string ToString()
        {
            return  "Account No: " + AccountNo +
                   "\nTotal Balance: " + TotalBalance +
                   "\nAccount Type: " + AccountType +
                   "\nCustomer Details: " + Customer.ToString() +
                   "\nBank: " + BankBranch.ToString() +
                   "\nRequired Balance: " + RequiredBalance;
        }

        public void filestorage()
        {
            string rootFolder = @"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\";
            string accountFile = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{AccountNo}.txt";
            if (File.Exists(accountFile))
            {
                Console.WriteLine("Account Already Exists");
            }
            else {
                using (StreamWriter writer = new StreamWriter(accountFile))
                {
                    writer.WriteLine("Account No: " + AccountNo +
                   "\nTotal-Balance: " + TotalBalance +
                   "\nAccount Type: " + AccountType +
                   "\nRequired Balance: " + RequiredBalance);
                    
                }
               
            }
        }

        public void depositmoney(int a,int money)
        {
            string rootFolder = @"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\";
            string accountFile = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{a}.txt";
            if (File.Exists(accountFile))
            {
                string[] lines = File.ReadAllLines(accountFile);
                foreach (string line in lines)
                {
                    if (line == "Total-Balance")
                    {
                        Console.WriteLine(line);
                    }
                    else
                    {
                        Console.WriteLine("Bug in if conditon");
                    }
                }
            }
        }

     
    }
}
