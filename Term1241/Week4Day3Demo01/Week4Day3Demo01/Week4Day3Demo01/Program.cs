namespace Week4Day3Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BREAK TIME : 5:39 - 5:49 pm
            
            //int float double string
            string studentName = "Harsimran"; 
            char studentGrade = 'A';

            bool isManager = false;
            
            Console.WriteLine(isManager);
            isManager = true;

            {
                int a;  // Declaring a variable inside a block
                a = 5;
            }
            //a = 5; // You won't be able to access it here because scope of this variable is limited to block above


            Console.WriteLine(isManager);

            //Prompt the user for grade and store it in studentGrade
            Console.Write("Enter your grade: ");
            studentGrade = char.Parse(Console.ReadLine());

            // Print the grade value back to user
            Console.WriteLine($" Grade = {studentGrade}");

        }
    }
}