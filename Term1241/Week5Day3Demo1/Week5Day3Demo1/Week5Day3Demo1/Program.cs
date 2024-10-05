namespace Week5Day3Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables here
            double score;

            // Prompt your for inputs
            Console.Write("Enter your score: ");
            score = double.Parse(Console.ReadLine());

            // Processing
            // If score     Grade
            //     >= 90 -     A
            /*     >= 80 -     B 
             *     >= 60 -     C
             *     >= 50 -     D
             *     <50   -     F 
             */
            if (score >= 90)
            {   // if condition is true
                Console.WriteLine("Grade A");
            }
            else if (score >= 80)
            {    // if condition 
                Console.WriteLine("Grade B");
            }
            else if (score >= 60)
            {    // if condition 
                Console.WriteLine("Grade C");
            }
            else if (score >= 50)
            {    // if condition 
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
            
            

            // Test Data
            /*
              Values     Expected Result    Actual Result
                95           A             
                90           A
Value less than 50           F
                Form rest of the cases
             */
        }
    }
}