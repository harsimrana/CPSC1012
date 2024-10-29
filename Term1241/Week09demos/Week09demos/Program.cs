namespace Week09demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call your method
            //First Call to my method
            DoSomething("Something");  // arguments

            //Second call with different values
            // In regular call to your method, the values should be in right order
            DoSomething("Harsimranjot", 10);
            // What we can override this behaviour by using named arguments

            DoSomething(a: 10, message: "Harsimranjot");

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
        public static void DoSomething(string message, int a = 5)
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
