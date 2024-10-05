namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            float testScore1 = 6.5f;
            float testScore2 = 7.5f;
            float testScore3 = 8.5f;
            float average;

            //Processing
            average = (testScore1 + testScore2 + testScore3) / 3; 

            //Output
            Console.WriteLine("Test Score 1: " + testScore1);
            Console.WriteLine("Test Score 2: " + testScore2);
            Console.WriteLine("Test Score 3: " + testScore3);
            Console.WriteLine("Average score: " + average);

        }
    }
}
