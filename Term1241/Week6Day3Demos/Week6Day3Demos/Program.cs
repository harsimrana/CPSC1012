namespace Week6Day3Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Formatting strings
            int i = 150;
            double f = 1234.56789;

            // Adding Colors: Bonus
            Console.ForegroundColor = ConsoleColor.Blue; // Text color

            //Change back ground color

            Console.BackgroundColor = ConsoleColor.White; // Background of Text

            // Title for my program
            Console.WriteLine("Formattig of strings");
            Console.WriteLine("======================");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red; // Text color

            //Change back ground color

            Console.BackgroundColor = ConsoleColor.Black; // Background of Text

            Console.WriteLine("i: {0:0000} f: {1:0.00}", i, f);

            // Make it even for fancy
            Console.WriteLine("i: {0:#,##0} f: {1:##,##0.00}", i, f);

            // Reset color settings

            Console.ResetColor(); // Reset color back to default colors

            // Print in columns- Right aligned 
            Console.WriteLine("i: {0,10:0} f: {1,15:0.00}", i, f);
            Console.WriteLine("i: {0,10:0} f: {1,15:0.00}", 0, 0);

            // Print in columns- Left aligned minus sign will cause it to be left aligned
            Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", i, f);
            Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", 0, 0);

            
        }
    }
}