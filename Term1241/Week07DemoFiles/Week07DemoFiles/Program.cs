namespace Week07DemoFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 7: Day 2
            // using simple variables
            /*
            int a = 4, b = 5, c = 6, d=7, e=4;
            int sum;

            sum = a + b + c + d + e;

            Console.WriteLine($"Sum of numbers: {sum}");
            */
            // Create and array
            // Syntax
            // Data type [] name = new Datatype [N];

            int[] scoreList = new int[5];
            int i; // Loop controller

            // Assign values to array elements
            for (i = 0; i <= 4; ++i)
            {
                Console.Write("Enter value: ");

                scoreList[i] = int.Parse(Console.ReadLine());
            }
            /*
            scoreList[1] = 5;
            scoreList[2] = 6;
            scoreList[3] = 7;
            scoreList[4] = 9;
            */

            // Access any element in an array
            // arrayName[index]
            for (i = 0; i <= 4; ++i)
            {
                Console.WriteLine($"{i+1} Element {scoreList[i]}");
            }
            /*
            Console.WriteLine($"2nd Element {scoreList[1]}");
            Console.WriteLine($"3rd Element {scoreList[2]}");
            Console.WriteLine($"4th Element {scoreList[3]}");
            Console.WriteLine($"5th Element {scoreList[4]}");
            */


        }
    }
}
