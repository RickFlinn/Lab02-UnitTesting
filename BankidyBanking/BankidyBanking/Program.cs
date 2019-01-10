using System;

namespace BankidyBanking
{
    class Program
    {
        public static decimal _balance = 0;

        static void Main(string[] args)
        {
            InterfaceFace();
            Console.WriteLine("Thank you for your business!");
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
                    int input = Convert.ToInt32(userInput);

                    if (input == 1)
                    {
                        DepositMenu();

                    } else if (input == 2)
                    {
                        WithdrawMenu();

                    } else if (input == 3)
                    {
                        ViewBalance();

                    } else if (input == 4)
                    {
                        isDone = true;
                        break;
                    }
                    
                } catch (FormatException)
                {
                    Console.WriteLine("Sorry, that was an invalid input. Please try entering 1, 2, 3, or 4.");
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                } finally
                {
                    try
                    {
                        Console.WriteLine("Would you like to make another transaction?");
                        string userYN = Console.ReadLine();
                        string yn = userYN.ToLower();
                        if (yn == "no" || yn == "n" || yn == "nope" || yn == "exit")
                        {
                            isDone = true;
                        }
                    } catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }

        public static void ViewBalance()
        {
            Console.WriteLine($"Your balance is: {_balance}.");
        }

        public static void DepositMenu()
        {
            Console.WriteLine("Please enter an amount to deposit.");
            try
            {
                string userSum = Console.ReadLine();
                int sum = Convert.ToInt32(userSum);
                Deposit(sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, invalid input.");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void Deposit(int amount)
        {
            if (amount >= 0)
            {
                _balance += amount;
                Console.WriteLine($"Depositing {amount} to your account.");
            } else
            {
                Console.WriteLine("Sorry, but negative deposit values are not accepted. Please use the withdraw function to pull funds from your account.");
            }
        }

        public static void Withdraw(int amount)
        {

        }
    }
}
