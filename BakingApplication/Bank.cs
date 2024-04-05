using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class Bank
    {
        // Data Member
        private string ifscCode;
        private string bankName;
        private Address address;
        private Contact[] contactDetails;

        // Default Constructor
        public Bank()
        {
            this.ifscCode = String.Empty;
            this.bankName = String.Empty;
            this.address = new Address();
            this.contactDetails = new Contact[1];
        }

        // Parameterized Constructor
        public Bank(string ifscCode, string bankName, Address address, Contact[] contactDetails)
        {
            IFSCCode = ifscCode;
            BankName = bankName;
            Address = address;
            this.contactDetails = contactDetails;
        }

        // Copy Constructor - Deep Copy
        public Bank(Bank bank)
        {
            this.ifscCode = bank.ifscCode;
            this.bankName = bank.bankName;
            this.address = bank.address;
            this.contactDetails = bank.contactDetails;
        }

        public string IFSCCode
        {
            get
            {
                return ifscCode;
            }
            set
            {
                if(Commons.CheckEmpty(value) && Commons.GetRegex(@"^[A-Z]{4}[0-9]{7}$").IsMatch(value))
                {
                    this.ifscCode = value;
                }
                else
                {
                    Console.WriteLine("IFSC Code not valid.");
                    ifscCode = String.Empty;
                }
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string BankName
        {
            get
            {
                return bankName;
            }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    this.bankName = value;
                }
            }
        }

        public Contact this[int i]
        {
            get
            {
                return contactDetails[i];
            }
            set
            {
                contactDetails[i] = value;
            }
        }

        public string GetAddress()
        {
            return address.ToString();
        }

        public override string ToString()
        {
            string str = "IFSC Code: " + IFSCCode +
                   "\nBank Name: " + BankName +
                   "\nAddress: " + Address +
                   "\nContact Details:\n";

            for(int i = 0; i < contactDetails.Length; i++)
            {
                str += contactDetails[i].ToString() + ", ";
            }

            return str + "\n";
        }
    }
}
