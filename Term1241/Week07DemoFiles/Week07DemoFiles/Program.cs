using System.Collections.Immutable;

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

            int listSize, sum=0;

            Console.Write("How many elements in your list: ");
            listSize = int.Parse(Console.ReadLine());
            
            int[] scoreList = new int[ listSize ];
            int i; // Loop controller

            double average; // To store mean average

            // Input from User
            // Assign values to array elements
            for (i = 0; i < listSize; ++i)
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
            // Sort your numbers
            // Use built in feature of Array Class: Sort() method

            Array.Sort(scoreList);


            // Add all the list elements  and return final sum 
            i = 0; // Initial value
            while (i < listSize) // Condition
            {
                sum = sum + scoreList[i];

                // Modification of initial value
                i++;
            }

            // Printing them back to user
            // Access any element in an array
            // arrayName[index]
            for (i = 0; i < listSize; ++i)
            {
                Console.WriteLine($"{i+1} Element {scoreList[i]}");
            }

            Console.WriteLine($"Sum of Numbers: {sum}");

            // Find mean average
            // average = Sum of number / number of element

            average = (double)sum / listSize;

            Console.WriteLine($" Mean average = {average}");

            /*
            Console.WriteLine($"2nd Element {scoreList[1]}");
            Console.WriteLine($"3rd Element {scoreList[2]}");
            Console.WriteLine($"4th Element {scoreList[3]}");
            Console.WriteLine($"5th Element {scoreList[4]}");
            */


        }
    }
}
