using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public interface IAccount
    {
        public string AccountNo { get; set; }
        public Commons.AccountType AccountType { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal WithdrawalLimit { get; set; }
        public decimal DepositLimit { get; set; }
        public Customer Customer { get; set; }
        public decimal RequiredBalance { get; set; }
        public Bank BankBranch { get; set; }

        public string ToString();
    }
}
