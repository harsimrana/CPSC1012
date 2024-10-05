namespace Week4Day2Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring required variables
            double a, b, c;

            //Title of Program
            Console.WriteLine("Hypotenuse Calculator for right angle Triangle");
            Console.WriteLine("========================");
            Console.WriteLine();

            // Inputs from user
            Console.Write("Enter the value of base: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of height: ");
            a = double.Parse(Console.ReadLine());

            // Processing: 

            c = Math.Sqrt( (a * a) + (b * b) );

            //Output back to user
            
            Console.WriteLine($"\nHypotenuse = {c:0.00}");
        }
    }
}
