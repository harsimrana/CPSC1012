namespace Week3Day3Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for input(s) and Output(s)
            double side, area;

            // Adding title 
            Console.WriteLine("Hexagon Area Calculator");
            Console.WriteLine("=========================");
            Console.WriteLine();

            // Take input(s) from user
            Console.Write("Enter the side of hexagon: ");
            side = double.Parse(Console.ReadLine());

            // Calculating Area of Hexagon
            area = (3 * Math.Sqrt(3)) / 2 * side * side;

            // Printing the result back to User

            Console.WriteLine($"Area of Hexagon: {area:0.0000}" );
            

        }
    }
}