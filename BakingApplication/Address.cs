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

        public int AddressId { get; }
        public string AddressLine { get; }
        public string State { get; }
        public string City { get; }
        public string Country { get; }
        public string PinCode { get; }

        public override string ToString()
        {
            return addressLine + ", " + state + ", " + city + ", " + country;
        }
    }
}
