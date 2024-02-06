using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calismaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;


            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose between ROCK,PAPER and SCISSORS:       ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();


                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Entry!");

                            break;
                    }
                    Console.WriteLine("\n\nSCORES : \tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);



                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player WON!!");
                    }
                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("CPU WON!!");
                    }
                    else
                    {

                    }

                    Console.WriteLine("Do you want to play again?(yes/no)");
                    string loop = Console.ReadLine();


                    if (loop == "yes")
                    {
                        playAgain = true;
                        Console.Clear();

                    }
                    else if (loop == "no")
                    {
                        playAgain = false;
                    }
                    else
                    {

                    }












                }
            }
        }


    }
}