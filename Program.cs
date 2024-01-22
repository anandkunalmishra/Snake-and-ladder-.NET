namespace Snake_And_Ladder
{
    class Gameplay
    {
        public static int rolldie(Random random)
        {
            return random.Next(1, 7);
        }
        public static void Main(String[] args)
        {
            int initialPositon = 0;

            Random random = new Random();

            int rolldieValue = rolldie(random);

            Console.WriteLine($"The rolling die value is {rolldieValue}");

           
            //The below line protects the program from stopping abruptly
            Console.ReadLine();
        }
    }
}
