namespace Week4Day3Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Title of Demo
            Console.WriteLine(" Week4 Day 3 Demo02");

            // String 
            string name = "HaRsiMran";
            string nameInUpperCase;
            string nameInLowerCase;
            string firstName = "Harsimran", lastName = "Aulakh";
            // Joining string values using + operator
            string nameStu = firstName + " " + lastName;

            Console.WriteLine($"Combined String: {nameStu} ");

            // Concat() - will join strings
            nameStu = String.Concat(firstName," ", lastName);

            Console.WriteLine($"Combined String: {nameStu} ");

            // Access individual chars by using index
            //               name[index] - index starts from 0
            Console.WriteLine(name[3]);

            // Length - property from String class
            // It will give you the length of the string
            // Syntax 
            // stringVariable.Length
            Console.WriteLine($"Total Number of characters in your name= {name.Length}");

            // ToUpper() - converts the string into upper case
            nameInUpperCase = name.ToUpper();
            Console.WriteLine($"Name is Capital Case = {nameInUpperCase}");

            // ToLower() - converts the string into lower case
            nameInLowerCase = name.ToLower();
            Console.WriteLine($"Name is Lower Case = {nameInLowerCase}");

        }
    }
}