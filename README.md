## Lab02-UnitTesting

# BankidyBanking 


BankidyBanking provides a no-frills, simulated automated banking experience through your computer's console,
and features a set of external methods for withdrawing, depositing, and viewing the balance of
your virtual account.



## Implementation
BankidyBank is a public, static class with several external methods used to simulate ATM transactions.
It is important to note that the "balance", accessed as ```C# Program._balance```, is not specific to an individual user or class instance,
and exists as a static, public property, that can be manually set. By default, when the program is run, 
the balance is set to zero.

```C#
Console.WriteLine(Program._balance); // 0
Program._balance = 400;
Console.WriteLine(Program._balance); // 400
```

]