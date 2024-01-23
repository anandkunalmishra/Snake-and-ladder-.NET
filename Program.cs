namespace Snake_And_Ladder
{
    class Gameplay
    {
        //checks the value of the die rolled
        public static int rolldie(Random random)
        {
            return random.Next(1, 7);
        }

        //checks the value for the gameplay
        public static int checkGameplay(Random random)
        {
            Console.WriteLine("Choose from option 1 - 3");
            int number = random.Next(1, 4);
            return number;
        }


        //driver function
        public static void Main(String[] args)
        {
            //assign the initial position for the player
            int Position = 0;

            //roll die work 
            Random random = new Random();
            int rolldieValue = rolldie(random);
            Console.WriteLine($"The rolling die value is {rolldieValue}");

            //cases
            int rollCount = 0;
            while(Position < 100)
            {
                int cases = checkGameplay(random);
                int newrolldievalue = rolldie(random);

                switch (cases)
                {   
                    case 1:
                        Console.WriteLine("No Play");
                        Position += 0;
                        rollCount++;
                        Console.WriteLine($"The roll count is {rollCount} and position is {Position}");
                        break;

                    case 2:
                        Console.WriteLine("Ladder Case");
                        if(Position+newrolldievalue <= 100)
                        {
                            Position += newrolldievalue;
                        }

                        rollCount++;
                        Console.WriteLine($"The roll count is {rollCount} and position is {Position}");
                        break;

                    case 3:
                        Console.WriteLine("Snake Case");
                        if (Position - newrolldievalue > 0)
                        {
                            Position -= newrolldievalue;
                        }
                        rollCount++;
                        Console.WriteLine($"The roll count is {rollCount} and position is {Position}");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }


            }



           
            //The below line protects the program from stopping abruptly
            Console.ReadLine();
        }
    }
}
