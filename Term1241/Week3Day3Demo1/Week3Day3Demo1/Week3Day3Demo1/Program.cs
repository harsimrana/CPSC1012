/* ******************************************************
 * Program to calculate area and volume of a Cylinder
 * Author: Harsimranjot 
 * Section: E02
 * Date of Submission: 20.09.2024
 * Instructor Name: Harsimranjot
 * ******************************************************/
namespace Week3Day3Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables required
            double radius, length, area, volume;
            
            // Title of the program
            Console.WriteLine("\tArea and Volume Calculator ");
            Console.WriteLine("\t============================");
            Console.WriteLine("");

            // Take inputs from user
            Console.Write("Enter the value of radius of Cylinder: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of length of Cylinder: ");
            length = double.Parse(Console.ReadLine());

            // Computes Area & Volume 

            area = radius * radius * Math.PI ;
            volume = area * length;

            // Output the result

            Console.WriteLine($"\nArea of Cylinder = {area:0.00} ");
            Console.WriteLine($"Volume of Cylinder= {volume:0.00}");
        }
    }
}