## Lab02-UnitTesting

# BankidyBanking 


BankidyBanking provides a no-frills, simulated automated banking experience through your computer's console,
allowing the user to withdraw, deposit, and view their balance.

## Implementation
BankidyBank is a public, static class with several external methods used to simulate ATM transactions.

When run, presents a simple interface to the user asking them what transactions they would like to make. Allows the user to view
their current balance, deposit funds, withdraw funds, and determine when they are done making transactions. Continues running until the user elects to exit.


## Sample output
```
Welcome to BankidyBank! What would you like to do?
1. Deposit
2. Withdraw Cash
3. View My Balance
4. Exit
1 // user input
Please enter an amount to deposit.
400
Depositing 400 to your account.
Would you like to make another transaction?
y // user input
Welcome to BankidyBank! What would you like to do?
1. Deposit
2. Withdraw Cash
3. View My Balance
4. Exit
3 // user input 
Your balance is: 400.
Would you like to make another transaction?
n // user input 
Thank you for your business. Have a nice day!
Press any key to continue . . .
```

## Methods

### InterfaceFace()

When called, runs the "banking" interface by displaying a menu of potential options, reading user input as integers,
and allowing the user to take as many transactions as they woudl like. When the user elects to exit the program, 
thanks the user for their time and stops running. 
 
### ViewBalance()

 Displays a message to the user informing them of their current balance and returns the user's current balance as a decimal.


### DepositMenu()

Displays a menu that asks the user how much money they would like to deposit, and that adds that number
to their balance.
      
### WithDrawMenu()

Displays a menu that asks the user how much money they would like to withdraw, and then subtracts the given
number from their balance.

### Deposit(decimal amount)

Deposits the given amount into the user's account, tells the user how much they deposited, then returns the user's balance.
If the user attempts to withdraw a negative amount, instead informs the user that negative withdrawals are not accepted.
        

### Deposit(decimal amount)

Takes in a decimal amount representing they amount the user would like to withdraw.
If the amount is greater than the user's balance, it will inform the user they have insufficient funds.
If the amount is negative, informs the user that negative values are not accepted.
If the amount is valid, subtracts the amount from the user's balance and informs them how much they withdrew.
       
### AnotherTransaction()

Asks the user if they would like another transaction. If the user does not, returns false. Otherwise, returns true.
       
