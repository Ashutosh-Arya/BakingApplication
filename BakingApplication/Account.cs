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

        public string AccountNo
        {
            get { return accountNo; }
            set
            {
                try
                {
                    if (Commons.CheckEmpty(value) /*&& Commons.GetRegex(@"^[0-9]{10}$").IsMatch(value)*/)
                    {
                        this.accountNo = value;
                    }
                    else
                    {

                        accountNo = String.Empty;
                        throw new Exception($"{this.accountNo} Account number not valid");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    throw;
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
                    Console.WriteLine("Invalid account balance " + value);
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
            set { requiredBalance = value; }
        }
        public Bank BankBranch
        {
            get { return bankBranch; }
            set { bankBranch = value; }
        }
        public string acccountdetails = "";
        public override string ToString()
        {
            return acccountdetails = "Account No: " + AccountNo +
                   "\nTotal Balance: " + TotalBalance +
                   "\nAccount Type: " + AccountType +
                   "\nCustomer Details: " + Customer.ToString() +
                   "\nBank: " + BankBranch.IFSCCode.ToString() +
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
            else
            {
                using (StreamWriter writer = new StreamWriter(accountFile))
                {
                    writer.WriteLine(this.ToString());

                }
                string passbook = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{AccountNo}passbook.txt";
                StreamWriter writer1 = new StreamWriter(passbook);
            }
        }

        public void depositmoney(int a, int money)
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

        public static void checkAccount(int a)
        {
            string rootFolder = @"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\";
            string accountFile = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{a}.txt";

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            if (File.Exists(accountFile))
            {
                try
                {
                    foreach (var line in File.ReadLines(accountFile))
                    {
                        // Skip empty lines
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // Split the line into key and value based on ':'
                        var parts = line.Split(new[] { ':' }, 2);

                        // Ensure we have exactly two parts
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            // Add to the dictionary
                            keyValuePairs[key] = value;
                        }
                        else
                        {
                            Console.WriteLine($"Ignoring malformed line: {line}");
                        }
                    }

                    // Output the key-value pairs
                    if (keyValuePairs.TryGetValue("Total Balance", out string totalBalanceValue))
                    {
                        Console.WriteLine($"Total Balance = {totalBalanceValue}");
                    }
                    else
                    {
                        Console.WriteLine("Key 'Total Balance' not found.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }
        }
        public static void DepositMoney(int account, decimal money)
        {
            string rootFolder = @"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\";
            string accountFile = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{account}.txt";
            string passbook = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{account}passbook.txt";

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            if (File.Exists(accountFile))
            {
                try
                {
                    foreach (var line in File.ReadLines(accountFile))
                    {
                        // Skip empty lines
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // Split the line into key and value based on ':'
                        var parts = line.Split(new[] { ':' }, 2);

                        // Ensure we have exactly two parts
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            // Add to the dictionary
                            keyValuePairs[key] = value;
                        }
                        else
                        {
                            Console.WriteLine($"Ignoring malformed line: {line}");
                        }
                    }


                    if (keyValuePairs.ContainsKey("Total Balance"))
                    {
                        if (decimal.TryParse(keyValuePairs["Total Balance"], out decimal currentValue))
                        {
                            decimal updatedValue = currentValue + money;
                            keyValuePairs["Total Balance"] = updatedValue.ToString();
                            Console.WriteLine($"Total Balance updated.{updatedValue}");

                            try
                            {
                                string line = "Deposit money on" + System.DateTime.Now + "="+ money;
                                File.AppendAllText(passbook, line + Environment.NewLine);
                               
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error appending to file: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The current value of 'Total Balance' is not a valid decimal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Key 'Total Balance' not found. Adding new key.");
                        keyValuePairs["Total Balance"] = money.ToString(); // Add the key with the initial value
                    }


                    // Save the updated dictionary back to the file
                    using (StreamWriter writer = new StreamWriter(accountFile))
                    {
                        foreach (var kvp in keyValuePairs)
                        {
                            writer.WriteLine($"{kvp.Key}:{kvp.Value}");
                        }
                    }

                    Console.WriteLine("File updated successfully.");


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }

        }

        public static void WithdrawMoney(int account, decimal money)
        {
            string rootFolder = @"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\";
            string accountFile = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{account}.txt";
            string passbook = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{account}passbook.txt";
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            

           
            
            if (File.Exists(accountFile))
            {
                try
                {
                    foreach (var line in File.ReadLines(accountFile))
                    {
                        // Skip empty lines
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // Split the line into key and value based on ':'
                        var parts = line.Split(new[] { ':' }, 2);

                        // Ensure we have exactly two parts
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            // Add to the dictionary
                            keyValuePairs[key] = value;
                        }
                        else
                        {
                            Console.WriteLine($"Ignoring malformed line: {line}");
                        }
                    }


                    if (keyValuePairs.ContainsKey("Total Balance"))
                    {
                        if (decimal.TryParse(keyValuePairs["Total Balance"], out decimal currentValue))
                        {

                            if (money >= 0.0M && money <= currentValue)
                            {
                                decimal updatedValue = currentValue - money;


                                keyValuePairs["Total Balance"] = updatedValue.ToString();
                                Console.WriteLine($"Total Balance updated. Currnt Money ={updatedValue}");
                                try
                                {
                                    string line = "Withdraw money on" + System.DateTime.Now + "=" + money;
                                    File.AppendAllText(passbook, line + Environment.NewLine);

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error appending to file: {ex.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid account balance "); 
                            }

                           
                        }
                        else
                        {
                            Console.WriteLine("The current value of 'Total Balance' is not a valid decimal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Key 'Total Balance' not found. Adding new key.");
                        keyValuePairs["Total Balance"] = money.ToString(); // Add the key with the initial value
                    }


                    // Save the updated dictionary back to the file
                    using (StreamWriter writer = new StreamWriter(accountFile))
                    {
                        foreach (var kvp in keyValuePairs)
                        {
                            writer.WriteLine($"{kvp.Key}:{kvp.Value}");
                        }
                    }

                    Console.WriteLine("File updated successfully.");


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }

        }

        public static void Passbook(int account)
        {
            string passbook = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{account}passbook.txt";
            if (File.Exists(passbook))
            {
                try
                {
                    foreach (var line in File.ReadLines(passbook))
                    {
                        Console.WriteLine(line);
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }
           
            else
            {
                Console.WriteLine($"Passbook file for account {account} does not exist.");
            }
            checkAccount(account);
        }

    
    } 
}