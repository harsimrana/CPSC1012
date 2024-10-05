namespace Week2Day3Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable to hold student Name
            string stuFirstName, stuLastName; // declaring a variable stuName with no initial value
            int classSize;

            // Input from user
            Console.Write("Enter your first name: "); // Prompt Message to user that what is expected
            stuFirstName = Console.ReadLine(); // Read a whole line as string

            Console.Write("Enter your last name: ");
            stuLastName = Console.ReadLine();

            Console.Write("Enter your class size: ");
            classSize = int.Parse( Console.ReadLine() );
            // int.Parse- will convert string input into interger value
            // float.Parse- will convert string into float value

            // Print a line on output screen
            // Print in this format Student Name = lastname firstname
            Console.WriteLine($"Student Name = {stuLastName} {stuFirstName}");
            Console.WriteLine($"Class Size = {classSize} ");
            
            
        }
    }
}