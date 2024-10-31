namespace Week9Day2Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call by value vs Call by reference
            int a = 5, b = 7;
            
            Console.WriteLine($"Before Calling method: Value of a = {a} and b = {b}");

            ChangeValues(ref a, ref b);

            Console.WriteLine($"After Calling method: Value of a = {a} and b = {b}");

        }

        static void ChangeValues(ref int a, ref int b)
        {
            Console.WriteLine($" Inside Method: Value of a = {a} and b = {b}");
            a = 10;
            b = 15;
            Console.WriteLine($" Inside Method After change: Value of a = {a} and b = {b}");
        }
    }
}
