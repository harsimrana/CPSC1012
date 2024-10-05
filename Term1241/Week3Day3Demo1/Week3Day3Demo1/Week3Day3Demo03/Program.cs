using System.Data;

namespace Week3Day3Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring all the variables required 
            int numb, sum, firDigit, secDigit, thiDigit;

            // Taking inputs form user

            Console.Write("Enter an Interger number (1-999): ");
            numb = int.Parse(Console.ReadLine());

            // Temp results Find digits
            firDigit = numb % 10; // First digit

            // Update the number- Remove last digit
            numb = numb / 10;

            secDigit = numb % 10; // Second digit

            // Update the number- Remove last digit
            numb = numb / 10;

            thiDigit = numb % 10;

            // Update the number- Remove last digit
            numb = numb / 10;


            // Calculate Sum of digits
            sum = firDigit + secDigit + thiDigit;

            // Output the sum of digits back to user
            Console.WriteLine($"Sum of digits of {thiDigit}{secDigit}{firDigit} = {sum} ");

        }
    }
}