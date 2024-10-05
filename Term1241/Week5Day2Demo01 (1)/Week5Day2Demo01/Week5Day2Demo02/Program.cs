namespace Week5Day2Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            // Prompt user for value
            Console.Write("Enter any value : ");
            a = int.Parse(Console.ReadLine());

            if (a >= 0)
            { // If above condition is true
                Console.WriteLine($"{a} is Positive");
            }
            else
            { // if above condition is false
                Console.WriteLine($"{a} is Negative");
            }
            Console.WriteLine("GoodBye thank you for using my program");
        }
    }
}
