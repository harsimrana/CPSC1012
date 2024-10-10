namespace Week6Day2Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print 5 stars on your screen in one line

            // this it one solution 
            //Console.WriteLine("*****");

            // Using loop for efficient way

            int i, j;

            // This nested loop will print following pattern
            // * * * * *
            // * * * * *
            // * * * * *
            // * * * * *

            /*for (j = 1; j <= 4; ++j)
            {
                for (i = 1; i <= 5; ++i) // Single Line 
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            */

            // Another question
            // * 
            // * * 
            // * * *
            // * * * *
            // 
            for (j = 1; j <= 4; ++j)
            {
                for (i = 1; i <= j; ++i) // Single Line 
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            // Another question
            // * 
            // * * *
            // * * * * *
            // * * * * * * *
            // 

            // Another question
            //        * 
            //      * * *
            //    * * * * *
            //  * * * * * * *
            //* * * * * * * * *

            // Another question
            //        * 
            //      * * 
            //    * * * 
            //  * * * * 
            //* * * * * 

        }
    }
}
