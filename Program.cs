using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string level;
            Console.WriteLine("Choose a level between Easy, Intermediate and Hard, 1 for Easy, 2 for Intermediate and 3 for Hard");
            Console.Write("What level would you like to play: ");
            var levelChose = int.Parse(Console.ReadLine());
            if (levelChose == 1)
            {
                level = "Easy";
            }
            else if (levelChose == 2)
            {
                level = "Intermediate";
            }
            else if (levelChose == 3)
            {
                level = "Hard";
            }
            else
            {
                level = "";
            }
            if (level == "Easy")
            {
                Game(6,1,10);
                
            }
            if (level == "Intermediate")
            {
                Game(4,1,20);
                
            }
            if (level == "Hard")
            {
                Game(3,1,50);
                
            }
        }
        public  static void Game (int trials, int Min, int Max)
        {
            Random random = new Random();
            int guess = random.Next(Min, Max);
            int Trials = 1;
            Console.Write("Enter a guess: ");
            int Guess = int.Parse(Console.ReadLine());
            do 
            {
                if(Trials == trials)
                {
                    Console.WriteLine("Sorry you loose");
                    break;

                }
                if (Guess != guess)
                {
                    Console.Write("Sorry, wrong number , Try again: ");
                    Guess = int.Parse(Console.ReadLine());
                    Trials++;
                }
                if (Guess == guess)
                {
                    Console.WriteLine($"Hey, You won, The number was {guess}");
                    break;
                } 
            }
            while(Guess != guess);

        }

    }
}
