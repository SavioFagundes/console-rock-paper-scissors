namespace Program
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;

            System.Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");

            while (playerScore != 3 && computerScore != 3)
            {
                System.Console.WriteLine("Player Score: " + playerScore + " | Computer Score: " + computerScore);
                System.Console.WriteLine("Please enter 'r' for Rock, 'p' for Paper, or 's' for Scissors");
                string playerChoice = Console.ReadLine().ToLower();

                int enemyChoice = new Random().Next(0, 3);

                if (enemyChoice == 0)
                {
                    System.Console.WriteLine("Computer chose Rock");

                    switch (playerChoice)
                    {
                        case "r":
                            System.Console.WriteLine("It's a tie!");
                            break;
                        case "p":
                            System.Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case "s":
                            System.Console.WriteLine("You lose!");
                            computerScore++;
                            break;
                        default:
                            System.Console.WriteLine("Invalid choice, please try again.");
                            continue;
                    }
                }
                else if (enemyChoice == 1)
                {
                    System.Console.WriteLine("Computer chose Paper");
                    switch (playerChoice)
                    {
                        case "r":
                            System.Console.WriteLine("You lose!");
                            computerScore++;
                            break;
                        case "p":
                            System.Console.WriteLine("It's a tie!");
                            break;
                        case "s":
                            System.Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        default:
                            System.Console.WriteLine("Invalid choice, please try again.");
                            continue;
                    }
                }
                else
                {
                    System.Console.WriteLine("Computer chose Scissors");
                    switch (playerChoice)
                    {
                        case "r":
                            System.Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case "p":
                            System.Console.WriteLine("You lose!");
                            computerScore++;
                            break;
                        case "s":
                            System.Console.WriteLine("It's a tie!");
                            break;
                        default:
                            System.Console.WriteLine("Invalid choice, please try again.");
                            continue;
                    }
                }
                System.Console.WriteLine("Current Score - Player: " + playerScore + ", Computer: " + computerScore);
                if (playerScore == 3)
                {
                    System.Console.WriteLine("Congratulations! You won the game!");
                }
                else if (computerScore == 3)
                {
                    System.Console.WriteLine("Sorry, the computer won the game!");
                }
                else
                {
                    System.Console.WriteLine("Let's play again!");
                }
            }
        }
    }
}