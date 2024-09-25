namespace Topic_5_assignment_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int rightNumber = 4;
            
            Console.WriteLine("Guess a number between 1-10");
            int.TryParse(Console.ReadLine(), out number);
            if (number == 1)
            {
                Console.WriteLine("Wrong!, the right number was "+rightNumber);
            }
            if (number == 2)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 3)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 4)
            {
                Console.WriteLine("Your right!");
            }
            if (number == 5)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 6)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 7)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 8)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 9)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
            if (number == 10)
            {
                Console.WriteLine("Wrong!, the right number was " + rightNumber);
            }
        }
    }
}
