namespace Week9Day2Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Sum of 5 and 4 = {CalculateAddition(5, 4)}");

            Console.WriteLine($" Sum of 5.5 and 4.5 = {CalculateAddition(5.5, 4.5)}");
        }
        // Method Overloading - means using same method name for 2 or 3 different methods
        //
        static double CalculateAddition(double a, double b)
        {
            double c;

            c = a + b;
            return c;
        }

        static int CalculateAddition(int a, int b)
        {
            int c;
            c = a + b;

            return c;

            // Shortcut way 
            //return a + b;
        }
    }
}
