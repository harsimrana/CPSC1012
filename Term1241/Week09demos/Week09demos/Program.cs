namespace Week09demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call your method
            //First Call to my method
            DoSomething("Something", 5);  // arguments
            //Second call with different values
            DoSomething("Harsimranjot", 10);

            int n = 4;

            int r = CalculateSqaure(n);

            Console.WriteLine($" Square of {n} = {r}");

            r = CalculateSqaure(5);

            Console.WriteLine($"Square of number is {r}");

        }
        // Method declaration for method DoSomething
        // Naming: 
        // 1. Pascal naming notation
        // 2. Start with verb
        //                              parameters
        public static void DoSomething(string message, int a)
        {
            Console.WriteLine(message);
            Console.WriteLine(a);
        }

        public static int CalculateSqaure(int a)
        {
            int result;

            result = a * a;

            //Console.WriteLine($" Sqaure of {a}= {result}");
            // Return a value back calling location

            return result; //Only one value can be returned
        }
    }
}
