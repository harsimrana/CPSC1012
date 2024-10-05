namespace Week5Day2Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            // Ask for a number

            Console.Write("Enter any value : ");
            a = int.Parse(Console.ReadLine());

            // Check whether number is odd or even
            // Based on that value give message to user
            if (a % 2 == 0)
            {
                // Print Even
                Console.WriteLine($"{a} is even");
            }
            else
            {
                // Odd number 
                Console.WriteLine($"{a} is odd");
            }

        }
    }
}
