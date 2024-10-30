namespace Week9Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            int age;

            username= Prompt("Enter the username: ");

            age = PromptInt("Enter your age :");

            Console.WriteLine($" Username = {username}");
        }
        // Method Problems 2 Q1
        /***************************
         * Function Name: Prompt
         * Purpose: It will show a label and return the string value back
         * Inputs: label: string
         * Output: string value [Input by user]
         * *************************/
        static string Prompt( string label)
        {
            string input;

            // display the label to user
            Console.Write(label);
            input = Console.ReadLine();

            // Return the string that has been entered
            return input;
        }

        /***************************
        * Function Name: PromptInt
        * Purpose: It will show a label and return an int value back
        * Inputs: label: string
        * Output: int value [Input by user]
        * *************************/
        static int PromptInt(string label)
        {
            int input;

            Console.Write(label);
            input = int.Parse(Console.ReadLine());

            return input;
        }

    }
}
