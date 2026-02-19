using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerpoints = 0;
            int enemypoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);

                Console.WriteLine("you rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);


                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("opponet rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerpoints++;
                    Console.WriteLine("player wins this round");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemypoints++;
                    Console.WriteLine("opponet wins this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("The score is now - Player :" + playerpoints + ". Enemy : " + enemypoints);
                Console.WriteLine();
            }

            if (playerpoints > enemypoints)
            {
                Console.WriteLine("you win");

            }
            else if (playerpoints < enemypoints)
            {
                Console.WriteLine("you loose");
                    
            }
            
        }
    }
}