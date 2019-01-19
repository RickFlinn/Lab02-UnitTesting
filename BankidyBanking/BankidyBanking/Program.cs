using System;

namespace BankidyBanking
{
    public class Program
    {
        // field that holds the user's balance.
        public static decimal _balance = 0;

        static void Main(string[] args)
        {
            InterfaceFace();
        }


        /// <summary>
        ///     When called, runs the "banking" interface by displaying a menu of potential options, reading user input as integers,
        ///         and allowing the user to take as many transactions as they woudl like. When the user elects to exit the program, 
        ///         thanks the user for their time and stops running. 
        /// </summary>
        public static void InterfaceFace()
        {
            bool isDone = false;
            while (!isDone)
            {
                try
                {
                    Console.WriteLine("Welcome to BankidyBank! What would you like to do?");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw Cash");
                    Console.WriteLine("3. View My Balance");
                    Console.WriteLine("4. Exit");

                    string userInput = Console.ReadLine();
                    string input = userInput.ToLower();

                    if (input == "4" || input == "four")
                    {
                        isDone = true;
                    } else
                    {
                        if (input == "1" || input == "one")
                        {
                            DepositMenu();

                        }
                        else if (input == "2" || input == "two")
                        {
                            WithdrawMenu();

                        }
                        else if (input == "3" || input == "three")
                        {
                            ViewBalance();
                        }
                        else
                        {
                            Console.WriteLine("Please select a menu item using the numbers 1 through 4.");
                        }
                        isDone = AnotherTransaction();
                    }
                    
                    

                } catch (FormatException)
                {
                    Console.WriteLine("Sorry, that was an invalid input.");
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                } 
                    
                
            }
            Console.WriteLine("Thank you for your business. Have a nice day!");
        }

        /// <summary>
        ///     Displays and returns the user's current balance.
        /// </summary>
        /// <returns> the user's balance, as a decimal </returns>
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your balance is: {_balance}.");
            return _balance;
        }


        /// <summary>
        ///     Displays a menu that asks the user how much money they would like to deposit, and that adds that number
        ///     to their balance.
        /// </summary>
        public static void DepositMenu()
        {
            Console.WriteLine("Please enter an amount to deposit.");
            try
            {
                string userSum = Console.ReadLine();
                decimal sum = Convert.ToDecimal(userSum);
                Deposit(sum);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        ///     Displays a menu that asks the user how much money they would like to withdraw, and then subtracts the given
        ///     number from their balance.
        /// </summary>
        public static void WithdrawMenu()
        {
            Console.WriteLine("Please enter the amount you would like to withdraw.");
            try
            {
                string userSum = Console.ReadLine();
                decimal sum = Convert.ToDecimal(userSum);
                Withdraw(sum);
            } catch
            {
                throw;
            }
        }
        
        /// <summary>
        ///     Deposits the given amount into the user's account, then tells the user how much they deposited.
        ///     If the user attempts to withdraw a negative amount, instead informs the user that negative withdrawals are not accepted.
        /// </summary>
        /// <param name="amount"> Amount to deposit in user's account </param>
        /// <returns> Current user's balance </returns>
        public static decimal Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                _balance += amount;
                Console.WriteLine($"Depositing {amount} to your account.");
            } else
            {
                Console.WriteLine("Sorry, but negative deposit values are not accepted. Please use the withdraw function to pull funds from your account.");
            }
            return _balance;
        }


        /// <summary>
        ///     Takes in a decimal amount representing they amount the user would like to withdraw.
        ///     If the amount is greater than the user's balance, it will inform the user they have insufficient funds.
        ///     If the amount is negative, informs the user that negative values are not accepted.
        ///     If the amount is valid, subtracts the amount from the user's balance and informs them how much they withdrew.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns> Current user's balance </returns>
        public static decimal Withdraw(decimal amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds. :(");
            } else if (amount < 0)
            {
                Console.WriteLine("Sorry, but negative withdrawal amounts are not accepted. Please use \"deposit\" to place funds in your account.");
            } else
            {
                _balance -= amount;
                Console.WriteLine($"Dispensing ${amount} from your account.");
            }
            return _balance;
        }

        /// <summary>
        ///     Asks the user if they would like another transaction. If the user does not, returns false. Otherwise, returns true.
        /// </summary>
        /// <returns> boolean representing whether the user is done making transactions </returns>
        public static bool AnotherTransaction()
        {
            try
            {
                Console.WriteLine("Would you like to make another transaction?");
                string userYN = Console.ReadLine();
                string yn = userYN.ToLower();

                if (yn == "no" || yn == "n" || yn == "nope" || yn == "exit")
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
