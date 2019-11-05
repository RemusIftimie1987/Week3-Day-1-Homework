using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentalsExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeReloaded snake1 = new SnakeReloaded();
            snake1.TestPlayerScores();

            Score score1 = new Score();
            try
            {
                Console.WriteLine("Please enter a number:");
                // 
                score1.PlayerScore = int.Parse(Console.ReadLine());
                score1.showScore();
            } catch (ScoreZeroException e)
            {
                Console.WriteLine("ScoreZeroException: {0}", e.Message);
            }
            Console.ReadKey();

            PacMania pm = new PacMania();
            pm.PacManiaCasting();

            ScreenCutter sc = new ScreenCutter();
            sc.SwitchScreenCutPercentage();
            
        }
    }
    public class SnakeReloaded
    {
        private int snakeSize;
        private double snakeRecords;
        public int SnakeSize { get => snakeSize; set => snakeSize = value; }
        public double SnakeRecords { get => snakeRecords; set => snakeRecords = value; }
        public void TestPlayerScores()
        {
            int player1 = 100;
            int player2 = 200;
            int player3 = 300;
            if (player1 < player2 || player1 > player3 && player2 == player3)
            {
                Console.WriteLine("The left side part of the condition has been met");
            }
            else if (!(player3 > player1))
            {
                Console.WriteLine("The code doesn't run on a negative situation as the condition is true");
            }
            else
            {
                Console.WriteLine("The student fail to understand conditions");
            }
        }
    }

    public class PacMania
    {
        // Use of casting
        public void PacManiaCasting()
        { 
        int pac = 1;
        //Boxing. copy the value of pac into object o
        object o = pac;
            try
            {
                int man = (int)o;  // Unboxing
                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }

        }
    }

        public class ScreenCutter
        {
        public void SwitchScreenCutPercentage()
        {
            // Use of switch and break 
            // To-do: Correct the logical error 
            int cutPercentage = 90;
            switch (cutPercentage)
            {
                case (0-30):
                    Console.WriteLine("Too low");
                    break;
                case (31 - 59):
                    Console.WriteLine("Just the warm up");
                    break;
                case (60 - 79):
                    Console.WriteLine("Almost there");
                    break;
                case (79 - 100):
                    Console.WriteLine("Great. Next Level!");
                    break;
                default:
                    Console.WriteLine($"An unexpected value ({cutPercentage})");
                    break;
            }
        }

        }

        public class ScoreZeroException: Exception
        {
            public ScoreZeroException(string message) : base(message)
            {
            }
        }
            public class Score
        {
            int playerScore = 0;

            public int PlayerScore { get => playerScore; set => playerScore = value; }

            public void showScore()
            {
                if (PlayerScore == 0)
                // User-defined exceptions
                {
                    throw (new ScoreZeroException("Score is 0! Not registering in Records"));
                }else if (PlayerScore < 0)
                {
                    throw (new ScoreZeroException("The player abandoned the game! Negative Score"));
                }
                else
                {
                    Console.WriteLine("Score: {0}", playerScore);
                }
            }
        }

    
}
