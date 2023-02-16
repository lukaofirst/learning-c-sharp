/* --- Upcasting and Downcasting --- */

using _012_upcasting_downcasting.Entities;

Account account = new Account(2012, "Lorem", 3051.25);
BusinessAccount businessAccount = new BusinessAccount(1012, "Ipsum", 9343.29, 1000);

// Upcasting - Implicit - The compiler infers the cast
Account account1 = businessAccount;
Account account2 = new BusinessAccount(1003, "Amet", 4030, 200);

// Downcasting - Explicit - You need to tell the compiler the correct cast
BusinessAccount account3 = (BusinessAccount) account1;
BusinessAccount account4 = (account2 as BusinessAccount)!;

if (account1 is BusinessAccount)
{
    // here, you can use .Loan() method "inside" the account1's class
    // using the account5 variable
    var account5 = account1 as BusinessAccount;
    Console.WriteLine("account1 is BusinessAccount");
}