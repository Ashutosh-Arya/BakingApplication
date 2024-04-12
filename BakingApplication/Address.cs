using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApplication
{
    public class Address
    {
        private int addressId;
        private string addressLine;
        private string state;
        private string city;
        private string country;
        private string pinCode;

        public Address()
        {
            this.addressId = 0;
            this.addressLine = String.Empty;
            this.state = String.Empty;
            this.city = String.Empty;
            this.country = String.Empty;
            this.pinCode = String.Empty;
        }

        public Address(int addressId, string addressLine, string state, string city, string country, string pinCode)
        {
            AddressId = addressId;
            AddressLine = addressLine;
            State = state;
            City = city;
            Country = country;
            PinCode = pinCode;
        }

        public int AddressId
        {
            get { return addressId; }
            set
            {
                if (Commons.CheckEmptyInt(value))
                {
                    this.addressId = value;
                }
                else
                {
                    Console.WriteLine("AddressId not valid");
                    this.addressId = 0;
                }
            }
        }
        public string AddressLine 
          { get { return addressLine; } 
            set {
                if (Commons.CheckEmpty(value))
                {
                    this.addressLine = value;
                }
                else
                {
                    Console.WriteLine("Address line not valid");
                    this.addressLine = String.Empty;
                }
            }
        }
        public string State
        {
            get { return state; }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    this.state = value;
                }
                else
                {
                    Console.WriteLine("state  not valid");
                    this.state = String.Empty;
                }
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    this.city = value;
                }
                else
                {
                    Console.WriteLine("City  not valid");
                    this.city = String.Empty;
                }
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    this.country = value;
                }
                else
                {
                    Console.WriteLine("Country  not valid");
                    this.country = String.Empty;
                }
            }
        }
        public string PinCode
        {
            get { return pinCode; }
            set
            {
                if (Commons.CheckEmpty(value)&&Commons.GetRegex(@"^[\d]{6}$").IsMatch(value))
                {
                    this.pinCode = value;
                }
                else
                {
                    Console.WriteLine("pinCode  not valid");
                    this.pinCode = String.Empty;
                }
            }
        }

        public override string ToString()
        {
            return addressLine + ", " + state + ", " + city + ", " + country + "," +pinCode;
        }
    }
}
