﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class SavingsAccount : IAccount
    {
        public SavingsAccount()
        {
          
        }

        public SavingsAccount(string accountNo, decimal totalBalance, decimal withdrawalLimit, decimal depositLimit, Customer customer, decimal requiredBalance, Bank bankBranch)
        {
            this.AccountNo = accountNo;
            this.TotalBalance = totalBalance;
            this.DepositLimit = depositLimit;
            this.Customer = customer;
            this.RequiredBalance = requiredBalance;
            this.BankBranch = bankBranch;
            this.WithdrawalLimit = withdrawalLimit;
        }

        public string AccountNo { get; set; }
        public Commons.AccountType AccountType { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal WithdrawalLimit { get; set; }
        public decimal DepositLimit { get; set; }
        public Customer Customer { get; set; }
        public decimal RequiredBalance { get; set; }
        public Bank BankBranch { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
