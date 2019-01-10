using System;

namespace BankidyBanking
{
    public class Program
    {
        public static decimal _balance = 0;

        static void Main(string[] args)
        {
            InterfaceFace();
        }

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

        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your balance is: {_balance}.");
            return _balance;
        }

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
