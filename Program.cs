using System;

namespace Snake_And_Ladder
{
    class Gameplay
    {
        public static int Position = 0;
        public static int rollCount = 0;

        //checks the value of the die rolled
        public static int RollDie(Random random)
        {
            return random.Next(1, 7);
        }

        //checks the value for the gameplay
        public static int CheckGameplay(Random random)
        {
            int number = random.Next(1, 4);
            return number;
        }

        public static void CasesPerform(int caseValue, int newRollDieValue)
        {
            switch (caseValue)
            {
                case 1:
                    Console.WriteLine("No Play");
                    Position += 0;
                    rollCount++;
                    break;

                case 2:
                    Console.WriteLine("Ladder Case");
                    if (Position + newRollDieValue <= 100)
                    {
                        Position += newRollDieValue;
                    }
                    rollCount++;
                    break;

                case 3:
                    Console.WriteLine("Snake Case");
                    if (Position - newRollDieValue > 0)
                    {
                        Position -= newRollDieValue;
                    }
                    rollCount++;
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            Console.WriteLine("\n");
           
        }

        public static void TwoPlayer(Random random)
        {
            int player1_Position = 0;
            int player2_Position = 0;

            while (player1_Position < 100 && player2_Position < 100)
            {
                // Player 1's turn
                int casesPlayer1 = CheckGameplay(random);
                int newRollDieValuePlayer1 = RollDie(random);
                CasesPerform(casesPlayer1, newRollDieValuePlayer1);
                player1_Position += newRollDieValuePlayer1;

                Console.WriteLine($"Player 1 position: {player1_Position}");

                if (player1_Position >= 100)
                {
                    Console.WriteLine("Player 1 wins");
                    break; // Exit the loop if Player 1 wins
                }

                // Player 2's turn
                int casesPlayer2 = CheckGameplay(random);
                int newRollDieValuePlayer2 = RollDie(random);
                CasesPerform(casesPlayer2, newRollDieValuePlayer2);
                player2_Position += newRollDieValuePlayer2;

                Console.WriteLine($"Player 2 position: {player2_Position}");

                if (player2_Position >= 100)
                {
                    Console.WriteLine("Player 2 wins");
                    break; // Exit the loop if Player 2 wins
                }
            }
        }


        //driver function
        public static void Main(string[] args)
        {
            //assign the initial position for the player
            int Position = 0;

            //roll die work 
            Random random = new Random();
            int rollDieValue = RollDie(random);
            Console.WriteLine($"The rolling die value is {rollDieValue}");

            //cases
            
            TwoPlayer(random);
            Console.WriteLine($"Total roll count is {rollCount}");
            // The below line protects the program from stopping abruptly
            Console.ReadLine();
        }
    }
}
