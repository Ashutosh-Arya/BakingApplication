﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class Commons
    {
        public static int bankCount = 0;
        public enum AccountType { SavingsAccount, CurrentAccount };
        

        public static Regex GetRegex(string str)
        {
            return new Regex(str);
        }
      
        // Validation and Filterting Input Methods
        public static string FilterInput(string input)
        {
            input = input.Trim();

            return input;
        }

        public static bool CheckEmpty(string input)
        {
            if (input == null /*|| input == String.Empty*/)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public static decimal ConvertToDecimal(string input)
        {
            input = FilterInput(input);

            if(input.Contains("."))
            {
                string[] inputs = input.Split('.');

                if (inputs[1].Length > 0 && inputs[1].Length <= 2)
                {
                    return Decimal.Parse(input);
                }
            }

            return Decimal.Parse("0.0");
        }

        public static bool CheckEmptyInt(int input)
        {
            if (input == null || input == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckEmptyDecimal(decimal input)
        {
            if (input == null  )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       public static string Account_number()
        {
            int inc = 1;
            string account_no;
            string accountFile;

            do
            {
                account_no = System.DateTime.Now.Year
                             + System.DateTime.Now.Month.ToString().PadLeft(2, '0')
                             + inc.ToString().PadLeft(4, '0');
                accountFile = $@"C:\Users\ashut\source\repos\BakingApplication\BakingApplication\Account-details\{account_no}.txt";
                inc++;
            }
            while (File.Exists(accountFile));

            return account_no;
        }


    }
}
