namespace Week5Day3Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a variable for age
            int age;

            // Take age value from user
            Console.Write("Enter your age");
            age = int.Parse(Console.ReadLine());

            //Processing : Deciding admission cost
            if (age <= 6)  /// BREAK TIME 5:50 to 6:00 PM
            {
                Console.WriteLine("You can enjoy the visit free of cost");
            }
            else if (age >= 7 && age <= 17)  // Logical && - And Both conditions should be true
            {
                Console.WriteLine("Cost of admission: $9.80");
            }
            else if (age >= 18 && age <= 54)
            {
                Console.WriteLine("Cost of admission: $11.35");
            }
            else // it means 55+
            {
                Console.WriteLine("Cost of admission: $10.00");
            }

            // Test Data    Expected Output    Actual output
            /*   5              Free            Free
             *   6              Free            Free
             *   9              $9.80           $9.80
             *   25             $11.35   
             *   60             $10.00
             */

            /* Logical operators                        AND       OR     Exclusive Or       Logical Not
             * Operator         C1           C2         && (x)   || +       ^                   !  - negate the condition
             *                  1            1          1         1         0                   1  -- 0
             *                  1            0          0         1         1                   0  -- 1 
             *                  0            1          0         1         1
             *                  0            0          0         0         0
             *                  
             */

        }
    }
}