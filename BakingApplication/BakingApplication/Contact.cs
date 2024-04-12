using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class Contact
    {
        private int contactId;
        private string phoneNo;
        private string email;

        public Contact()
        {
            this.contactId = 0;
            this.phoneNo = String.Empty;
            this.email = String.Empty;
        }

        public Contact(int contactId, string phoneNo, string email)
        {
            ContactId = contactId;
            PhoneNo = phoneNo;
            Email = email;
        }

        public int ContactId
        {
            get { return this.contactId; }
            set
            { if(Commons.CheckEmptyInt(value))
                {
                    this.contactId = value;
                }
                else
                {
                    Console.WriteLine("Contact ID Invalid");
                }
                 
            }
        }

        public string PhoneNo
        {
            get { return this.phoneNo; }
            set
            {
                if (Commons.CheckEmpty(value) && Commons.GetRegex(@"^[\d*]{10}$").IsMatch(value))
                {
                    this.phoneNo = value;
                }
                else
                {
                    Console.WriteLine("Contact Invalid");
                    this.phoneNo = string.Empty;
                }

            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (Commons.CheckEmpty(value) && Commons.GetRegex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(value))
                {
                    this.email = value;
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                    this.email = String.Empty;
                }
            }
        }

        public override string ToString()
        {
            return ContactId + ", " + PhoneNo + ", " + Email;
        }
    }
}
