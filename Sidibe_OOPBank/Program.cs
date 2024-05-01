namespace Sidibe_OOPBank
{
    internal class Program
    {
        static ConsoleKeyInfo DisplayMenu() 
        {
            ConsoleKeyInfo UserChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome back! What would you like to do?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      (B)alance          (D)eposit          (W)ithdraw          (Q)uit" );

                UserChoice = Console.ReadKey(true);

            } while ( UserChoice.Key != ConsoleKey.B && UserChoice.Key != ConsoleKey.D && UserChoice.Key != ConsoleKey.W && UserChoice.Key != ConsoleKey.Q );

            return UserChoice;
        }

        static void ReturnToMenu() 
        {
            ConsoleKeyInfo UserChoice;

            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the menu.");

            do
            {
                UserChoice = Console.ReadKey(true);

            } while (UserChoice.Key != ConsoleKey.Enter);

            Console.Clear();
        }

        static void Reconnect() 
        {
            Console.WriteLine();
            Console.WriteLine("Press any key if you wish to reconnect.");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            Bank UserAccount;
            ConsoleKeyInfo UserChoice;
            string Message;
            string UserInput;
            decimal Amount;

            UserAccount = new Bank(1000M);

            do 
            {
                UserChoice = DisplayMenu();

                if (UserChoice.Key == ConsoleKey.B) 
                {
                    Console.Clear();
                    Message = UserAccount.CheckBalance();
                    Console.WriteLine(Message);

                    ReturnToMenu();

                }
                else if (UserChoice.Key == ConsoleKey.D) 
                {
                    Console.Clear();
                    Console.Write("Enter the amount you would like to deposit: ");
                    UserInput = Console.ReadLine();
                    Amount = decimal.Parse(UserInput);
                    Console.WriteLine();
                    Message = UserAccount.MakeDeposit(Amount);
                    Console.WriteLine(Message);

                    ReturnToMenu();

                }
                else if (UserChoice.Key == ConsoleKey.W) 
                {
                    Console.Clear();

                    if (UserAccount.Balance == 0) 
                    {
                        Console.WriteLine("Sorry. Withdrawals are not allowed at this time.");
                        Console.WriteLine();
                    }
                    else 
                    {
                        Console.Write("Enter the amount you would like to withdraw: ");
                        UserInput = Console.ReadLine();
                        Amount = decimal.Parse(UserInput);
                        Console.WriteLine();
                        Message = UserAccount.MakeWithdrawal(Amount);
                        Console.WriteLine(Message);
                    }

                    ReturnToMenu();

                }
                else if (UserChoice.Key == ConsoleKey.Q) 
                {
                    Console.Clear();
                    Console.WriteLine("Have a wonderful day, and thank you for choosing our bank.");

                    Reconnect();

                }

            }while (true);
        }
    }
}