/**********************
 * Program: Assignment 01
 * Author: Harsimran 
 * Instrutor: Harsimran 
 * 
 * ********************/
namespace Week4Day2Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring required variables
            float numb1, numb2, numb3, meanAvg;

            // Declare Constant for count of numbers
            const int COUNT_NUMBERS = 3;

            //Title of Program
            Console.WriteLine("Mean Average Calculator");
            Console.WriteLine("========================");
            Console.WriteLine();

            //Inputs
            Console.Write("Enter first number: ");
            numb1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Second number: ");
            numb2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Third number: ");
            numb3 = float.Parse(Console.ReadLine());
            
            //Processing : Calculating mean average

            meanAvg = (numb1 + numb2 + numb3) / COUNT_NUMBERS;

            //Output
            Console.WriteLine();
            Console.WriteLine($"Mean Average of three numbers = {meanAvg:0.00}");

            // Q2
            Console.WriteLine($"Mean Average of three numbers = {Math.Round(meanAvg, 2)}");

        }
    }
}
