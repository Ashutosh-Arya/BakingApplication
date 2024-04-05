using BakingApplication;

Console.WriteLine("Hello, World!");

Address address = new Address(addressId: 1, city: "New Delhi", state: "Delhi", addressLine: "Kohat Enclave", country: "India", pinCode: "110088");
Contact[] contacts = new Contact[1];
contacts[0] = new Contact(phoneNo: "9875461203", contactId: 1, email: "example@example.com");

Bank bank = new Bank(ifscCode: "SBIN0000045", bankName: "", address: address, contactDetails: contacts);


Console.WriteLine(bank.ToString());

//Customer customer = new Customer();
//Account account = new Account(accountNo:"1234568790", totalBalance:-5, withdrawalLimit: 5000, depositLimit :- 200, customer:customer, requiredBalance: 1000, bankBranch:bank);

//Console.WriteLine(account.ToString());