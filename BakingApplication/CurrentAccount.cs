using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            AccountNo = String.Empty;
            TotalBalance = 0.0M;
            WithdrawalLimit = 100000;
            DepositLimit = 20000;
            Customer = new Customer();
            RequiredBalance = 1200.0M;
            BankBranch = new Bank();
        }
        public CurrentAccount(string accountNo, decimal totalBalance, decimal withdrawalLimit, decimal depositLimit, Customer customer, decimal requiredBalance, Bank bankBranch)

        {
            AccountNo = accountNo;
            TotalBalance = totalBalance;
            DepositLimit = depositLimit;
            Customer = customer;
            RequiredBalance = requiredBalance;
            BankBranch = bankBranch;
            WithdrawalLimit = withdrawalLimit;
        }

        public  string AccountNo
        {
            get
            {
                return base.AccountNo;
            }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    base.AccountNo = value;
                }
                else
                {
                    Console.WriteLine("Account No- not valid");
                    base.AccountNo = String.Empty;
                }
            }
        }
        public Commons.AccountType AccountType { get; set; }
        public new decimal TotalBalance
        {
            get
            {
                return base.TotalBalance;
            }
            set

            {
                if (Commons.CheckEmptyDecimal(value))
                {
                    base.TotalBalance = value;
                }
                else
                {
                    Console.WriteLine("Account No not valid");
                    base.TotalBalance = 0.0M;
                }
            }
        }
        public decimal WithdrawalLimit { get; set; }
        public decimal DepositLimit { get; set; }
        public Customer Customer { get; set; }
        public decimal RequiredBalance { get; set; }
        public Bank BankBranch { get; set; }

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
