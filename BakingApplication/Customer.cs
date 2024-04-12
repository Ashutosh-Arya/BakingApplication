using static BakingApplication.Commons;

namespace BakingApplication
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private Address tempAddress;
        private Address permanentAddress;
        private Contact primaryContactDetails;
        private Contact? secondaryContactDetails;

        // Default Constructor
        public Customer()
        {
            this.customerId = 0;
            this.firstName = String.Empty;
            this.lastName = String.Empty;
            this.tempAddress = new Address();
            this.permanentAddress = new Address();
            this.primaryContactDetails = new Contact();
            this.secondaryContactDetails = null;
        }

        // Parameterized Constructor
        public Customer(int customerId, string firstName, string lastName, Address tempAddress, Address permanentAddress, Contact primaryContactDetails, Contact secondaryContactDetails)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            TempAddress = tempAddress;
            PermanentAddress = permanentAddress;
            PrimaryContactDetails = primaryContactDetails;
            SecondaryContactDetails = secondaryContactDetails;
        }
        public int CustomerId
        {
            get
            {
                return this.customerId;
            }
            set
            {
                if (Commons.CheckEmptyInt(value))
                {
                    this.customerId = value;
                }
                else
                {
                    Console.WriteLine("Fisrt Name " + value + " Invalid");
                }
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    this.firstName = value;
                }
                else
                {
                    Console.WriteLine("Fisrt Name "+value+" Invalid");
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (Commons.CheckEmpty(value))
                {
                    this.lastName = value;
                }
                else
                {
                    Console.WriteLine("LastName Name "+value+" Invalid");
                }
            }
        }
        public Address TempAddress { get; }
        public Address PermanentAddress { get; }
        public Contact PrimaryContactDetails { get; }
        public Contact SecondaryContactDetails { get; }

        public string ToString()
        {
            return "Account No: " + CustomerId +
                   "\nFirstName: " + FirstName +
                   "\nLastName: " + LastName;
        }
    }
}