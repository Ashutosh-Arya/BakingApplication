using BakingApplication;


Address address = new Address(addressId: 1, city: "New Delhi", state: "Delhi", addressLine: "Kohat Enclave", country: "India", pinCode: "100088");

Contact[] contacts = new Contact[1];
contacts[0] = new Contact(phoneNo: "9875461203", contactId: 1, email: "HDFC@HDFCI.com");
Bank hdfcbank = new Bank(ifscCode: "HDFC0000045", bankName: "HDFC", address: address, contactDetails: contacts);

contacts[0] = new Contact(phoneNo: "9875461203", contactId: 1, email: "CentralBank@CentralBank.com");
Bank centalbank = new Bank(ifscCode: "CENT0000045", bankName: "Central Bank", address: address, contactDetails: contacts);

contacts[0] = new Contact(phoneNo: "9875461203", contactId: 1, email: "SBI@SBI.com");
Bank sbibank = new Bank(ifscCode: "SBIN0000045", bankName: "SBI", address: address, contactDetails: contacts);

contacts[0] = new Contact(phoneNo: "9875461203", contactId: 1, email: "ICICI@ICICI.com");
Bank icicibank = new Bank(ifscCode: "ICIC0000045", bankName: "ICICI", address: address, contactDetails: contacts);
    


Console.WriteLine("Dear User Do you have Account?\nEnter your choice Yes = 1 or No = 2");
int choice = Convert.ToInt32(Console.ReadLine().Trim());

if (choice == 1 ){
    Console.WriteLine("Enter your Account number");
    int accountnumber = Convert.ToInt32(Console.ReadLine().Trim());
    Commons.checkAccount(accountnumber);

    Console.WriteLine("want to deposit money");
    int money = Convert.ToInt32(Console.ReadLine().Trim());
    Account a = new Account();
    a.depositmoney(accountnumber, money);
}
else if (choice==2) { CreateAccount(); }
else  { Console.WriteLine("invalid input"); }

void CreateAccount()
{
    Console.WriteLine("Enter First your Name");
    string FirstName = Console.ReadLine().Trim();

    Console.WriteLine("Enter Last your Name");
    string LastName = Console.ReadLine().Trim();

    Console.WriteLine("Enter  your Email");
    string email = Console.ReadLine().Trim();

    Console.WriteLine("Enter contact number");
    string phonenumber = Console.ReadLine().Trim();

    Console.WriteLine("Enter  your Permanent Address lane");
    string lane = Console.ReadLine().Trim();

    Console.WriteLine("Enter your sate");
    string state = Console.ReadLine().Trim();

    Console.WriteLine("Enter  your city");
    string city = Console.ReadLine().Trim();

    Console.WriteLine("Enter  your counrty");
    string counrty = Console.ReadLine().Trim();

    Console.WriteLine("Enter  your PinCode");
    string PinCode = Console.ReadLine().Trim();

    Console.WriteLine("Enter primary Contact Details");
    string primaryContactDetails = Console.ReadLine().Trim();

    Address address1 = new Address(1, lane, state, city, counrty, PinCode);
    Contact contact = new Contact(1, phonenumber, email);

    Customer customer1 = new Customer(customerId: 1, firstName: FirstName, lastName: LastName, tempAddress: address1, permanentAddress: address1, primaryContactDetails: contact, secondaryContactDetails: contact);
    Console.WriteLine((customer1!=null)? "Profile Created" :" not created");
    Console.WriteLine("Which bank account you want to create \n1. SBI \n2. ICICI \n3. Central Bank \n4. HDFC ");
    int bankChoice = Convert.ToInt32(Console.ReadLine().Trim());
    Account account = new SavingsAccount();
    if (bankChoice == 1)
    {
        account= new SavingsAccount(accountNo: "1234567895", totalBalance: 0.00M, withdrawalLimit: 50000, depositLimit: 200000, customer: customer1, requiredBalance: 2000, bankBranch: sbibank);
        Console.WriteLine(account.ToString());

    }
    else if (bankChoice == 2)
    {
        account = new   SavingsAccount(accountNo: "1234567895", totalBalance: 0.00M, withdrawalLimit: 50000, depositLimit: 200000, customer: customer1, requiredBalance: 2000, bankBranch: icicibank);
        Console.WriteLine(account.ToString());
    }
    else if (bankChoice == 3)
    {
         account = new SavingsAccount(accountNo: "1234567895", totalBalance: 0.00M, withdrawalLimit: 50000, depositLimit: 200000, customer: customer1, requiredBalance: 2000, bankBranch: centalbank);
        Console.WriteLine(account.ToString());
    }
    else if (bankChoice == 4)
    {
         account = new SavingsAccount(accountNo: "1234567895", totalBalance: 0.00M, withdrawalLimit: 50000, depositLimit: 200000, customer: customer1, requiredBalance: 2000, bankBranch: hdfcbank);
        Console.WriteLine(account.ToString());
    }
    else
    {
        Console.WriteLine("Enter valid Choice");
    }
    account.filestorage();
 
}
void Getdetails()
{
    Console.WriteLine("Enter account number :"); 
    string userAccount = Console.ReadLine().Trim();
}
