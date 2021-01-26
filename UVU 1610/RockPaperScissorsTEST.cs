using System;
using System.Collections.Generic;
using System.Text;
using System.Treading.Taks;
using System.Math;


namespace ROCKPAPERSCISSORS
 {
     class Program
      {
        private const string Format = "CPU WINS!!\n\n);;

        static void Main(string[] args)
            {
                    string inputPlayer, inputCPU
                    int scorePlayer = 0;
                    int scoreCPU = 0;

                    Console.WriteLine("Choose between ROCK, PAPER, and SCISSORS");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

            int randomInt = rnd.Next(1, 4)

                    switch (randomInt)
                    {
                            case 1: 
                                 inputCPU = "ROCK";
                                 Console.WriteLine("Computer chose ROCK");
                                 if (inputPlayer == "ROCK")
                                 {
                                        Console.WriteLine("DRAW!!\n\n");


                                 }
                                 else if (inputPlayer == "PAPER")
                                 {
                                     Console.WriteLine("PLAYER WINS!!\n\n");
                                     scorePlayer++;
                                 }
                                 else if ("inputPlayer == "ROCK")
                                 {
                                     Console.WriteLine(Format
                                     scoreCPU++
                                 }
                                break;
                            case 2:
                                inputCPU = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("CPU WINS!! \n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 3:
                                inputCPU = "SCISSORS";
                                Console.WriteLline("Computer chose SCISSORS");
                                if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCk")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer "PAPER")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            

                                break;private static void NewMethod()
        {
            object sCISSORS = SCISSORS;
        }
    }
