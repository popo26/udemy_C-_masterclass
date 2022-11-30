/*
 Challenge - If Statements 2
Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.
 
 */

using System;

namespace _55_If_statements2
{
    internal class Program
    {
        static int highestScore = 300;
        static string highestScorePlayer = "Ramon";

        static void Main(string[] args)
        {
            Console.WriteLine("Whats your player name?");
            string player = Console.ReadLine();
            Console.WriteLine("Whats your score?");
            string score = Console.ReadLine();
            int scoreInt = int.Parse(score);

            CompareScores(scoreInt, player);
            Console.Read();
            
        }
        public static void CompareScores(int score, string player)
        {

            if (score > highestScore) {
                highestScore = score;
                highestScorePlayer = player;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + player);
            }else 
            {
                Console.WriteLine("The old highscore of " + highestScore 
                    + " could not be broken and is still held by " + highestScorePlayer);
            }
            
        }
    }
}
