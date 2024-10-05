namespace Week5Day3Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Uncomment the following to test it for Simple swtich statement
            /*
            int numb;

            Console.WriteLine("Menu Options");
            Console.WriteLine("=============================");
            Console.WriteLine("Press 1 for Movie");
            Console.WriteLine("Press 2 for Dinner Outside");
            Console.Write("Enter your choice: ");
            numb= int.Parse(Console.ReadLine());

            switch (numb)  // Condition or expression
            {
                case 1:  // Test cases - int, char, string 
                    Console.WriteLine("You pressed 1: Which movie you would to watch?");
                    break; // Mandatory after every case
                case 2:
                    Console.WriteLine("You pressed 2: Where are you going for dinner tonight?");
                    break;
                default:  // If there is no match 
                    Console.WriteLine("Sorry my friend I did not know. Try again with valid options!!");
                    break;
            }

            if(choice == 'Y' || choice=='y')
            {
                // True part 
            }
            else if(choice == 'N' || choice=='n')
            {
                //false
            }

            char choice = 'Y';
            switch (choice)  // Condition or expression
            {
                case 'y':  // Test cases - int, char, string 
                case 'Y':
                    Console.WriteLine("You pressed 1: Which movie you would to watch?");
                    break; // Mandatory after every case
                case 'n':
                case 'N':
                    Console.WriteLine("You pressed 2: Where are you going for dinner tonight?");
                    break;
                default:  // If there is no match 
                    Console.WriteLine("Sorry my friend I did not know. Try again with valid options!!");
                    break;
            }
            
            */
            // Calculator 
            double a, b, c; //  a and b are inputs and c is output

            int ch; // ch - for choice of user 

            // Prompt for 2 numbers
            Console.Write("Enter the first number: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = double.Parse(Console.ReadLine());

            // Menu to user to pick + - * or /

            Console.WriteLine("Menu Options");
            Console.WriteLine("=============================");
            Console.WriteLine("Press 1 for +");
            Console.WriteLine("Press 2 for -");
            Console.WriteLine("Press 3 for *");
            Console.WriteLine("Press 4 for /");
            Console.Write("Enter your choice: ");
            ch = int.Parse(Console.ReadLine());

            // Processing and output
            switch (ch)
            {
                case 1:
                    // Addition part
                    c = a + b;
                    Console.WriteLine($" {a} + {b} = {c}");
                    break;
                case 2:
                    // Minus
                    c = a - b;
                    Console.WriteLine($" {a} - {b} = {c}");
                    break;
                case 3:
                    // Multiplication
                    c = a * b;
                    Console.WriteLine($" {a} * {b} = {c}");
                    break;
                case 4:
                    // Division
                    c = a / b;
                    Console.WriteLine($" {a} / {b} = {c}");
                    break;
                default:
                    Console.WriteLine("Sorry my friend I did not know. Try again with valid options!!");
                    break;
            }
        }
    }
}