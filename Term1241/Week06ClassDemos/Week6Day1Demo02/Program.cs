namespace Week6Day1Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 06 Day 01 Demo 02 -- Looping
            char userChoice = 'Y';
            /* //User controlled loop
            while (userChoice== 'Y' || userChoice == 'y')
            {
                Console.WriteLine("Dem0 01");
                Console.Write("Do you want to continue Y/N");
                userChoice = char.Parse(Console.ReadLine());
            }
            */
            int i = 1;
            int n;

            Console.Write("Enter the start number: ");
            i = int.Parse(Console.ReadLine());

            Console.Write("Enter the last number: ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                if (i % 2 == 0) // Forcing for even numbers
                {
                    Console.Write($"  {i}");
                }
                //i = i + 1;
                i++;  // Increment operator[Unary Operator]: It will increase the value of operand by 1
            }


        }
    }
}
