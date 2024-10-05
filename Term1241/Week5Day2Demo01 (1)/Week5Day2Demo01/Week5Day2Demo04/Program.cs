namespace Week5Day2Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a variable to hold year value
            int year;
            int leapResult;

            // Taking value from user
            Console.Write("Enter the value of year");
            year = int.Parse(Console.ReadLine());
            // find leap year

           leapResult = year % 4;

            if (leapResult == 0)// Condition
            { // Curly brackets are optional if only one statement is there
                // if condition is true, Year is a leap year
                Console.WriteLine($"{year} is a leap year enjoy one extra day");
            }
            else
            {
                // if condition is false- Not a leap
                Console.WriteLine($"{year} is not a leap year. Sorry for that");
            }

        }
    }
}
