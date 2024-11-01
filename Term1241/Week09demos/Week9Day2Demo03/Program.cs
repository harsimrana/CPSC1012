namespace Week9Day2Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call by value vs Call by reference
            int a = 5, b = 7;
            
            Console.WriteLine($"Before Calling method: Value of a = {a} and b = {b}");

            // Passing a by reference and passing b by value. Observe the values after function call
            ChangeValues(ref a, b);

            Console.WriteLine($"After Calling method: Value of a = {a} and b = {b}");

        }

        static void ChangeValues(ref int a, int b)
        {
            Console.WriteLine($" Inside Method: Value of a = {a} and b = {b}");
            a = 10;
            b = 15;
            Console.WriteLine($" Inside Method After change: Value of a = {a} and b = {b}");
        }
    }
}
