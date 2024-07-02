using System.Collections;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int userScore = 0;
            int cpuScore = 0;
            int firstTo = 2;

            while (userScore < firstTo && cpuScore < firstTo)
            {

                int[] gameScore = RPSMethod(userScore, cpuScore);
                userScore = gameScore[0];
                cpuScore = gameScore[1];

                if (userScore < firstTo && cpuScore < firstTo)
                {
                    Console.WriteLine("Next Round");
                }
                else
                {
                    if (userScore > cpuScore)
                    {
                        Console.WriteLine("\nYou're a god\n");
                        
                    }
                    else
                    {
                        Console.WriteLine("\nYou're trash\n");
                    }


                }
              

            }

            Console.WriteLine("Would you like to play again? y/n");
            char reprompt = char.Parse(Console.ReadLine() ?? "");

            if (reprompt == 'y')
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Game Over");
            }

            static int[] RPSMethod(int userScore, int cpuScore)
            {

                Random rand = new Random();
                int randomInt = rand.Next(3);
                string cpuPick;


                const string WEAPON1 = "Rock";
                const string WEAPON2 = "Paper";
                const string WEAPON3 = "Scissors";

                Console.Write($"Please enter {WEAPON1}, {WEAPON2}, or {WEAPON3}: ");
                string userPick = Console.ReadLine() ?? "";



                switch (userPick)
                {
                    case WEAPON1:
                        if (randomInt == 1)
                        {
                            cpuPick = WEAPON2;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Paper");
                            Console.WriteLine();
                            Console.WriteLine("CPU Wins");
                            cpuScore++;
                        }
                        else if (randomInt == 2)
                        {
                            cpuPick = WEAPON3;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Scissors");
                            Console.WriteLine();
                            Console.WriteLine("You Win!");
                            userScore++;
                        }
                        else if (randomInt == 0)
                        {
                            cpuPick = WEAPON1;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Rock");
                            Console.WriteLine();
                            Console.WriteLine("Draw!");

                        }
                        break;
                    case WEAPON2:
                        if (randomInt == 1)
                        {
                            cpuPick = WEAPON2;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Paper");
                            Console.WriteLine();
                            Console.WriteLine("Draw!");

                        }
                        else if (randomInt == 2)
                        {
                            cpuPick = WEAPON3;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Scissors");
                            Console.WriteLine();
                            Console.WriteLine("CPU Wins");
                            cpuScore++;
                        }
                        else if (randomInt == 0)
                        {
                            cpuPick = WEAPON1;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Rock");
                            Console.WriteLine();
                            Console.WriteLine("You Win!");
                            userScore++;
                        }
                        break;
                    case WEAPON3:
                        if (randomInt == 1)
                        {
                            cpuPick = WEAPON2;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Paper");
                            Console.WriteLine();
                            Console.WriteLine("You Win");
                            userScore++;
                        }
                        else if (randomInt == 2)
                        {
                            cpuPick = WEAPON3;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Scissors");
                            Console.WriteLine();
                            Console.WriteLine("Draw!");

                        }
                        else if (randomInt == 0)
                        {
                            cpuPick = WEAPON1;
                            Console.WriteLine();
                            Console.WriteLine("CPU Picks Rock");
                            Console.WriteLine();
                            Console.WriteLine("CPU Wins");
                            cpuScore++;
                        }
                        break;



                }
                return [userScore, cpuScore];




            }
        }
    }
}

