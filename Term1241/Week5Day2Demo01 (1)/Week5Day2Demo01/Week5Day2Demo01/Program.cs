namespace Week5Day2Demo01
{
    // BREAK TIME 5:45 to 5:55
    internal class Program
    {
        static void Main(string[] args)
        {
            bool oddOrEven = true;
            oddOrEven = false;

            string name = "Harsimranjot Singh";
            string name1 = "Ab";

            // To find substring 
                                    //   start, length
            Console.WriteLine(name.Substring(1,2));


            // To compare two strings
            Console.WriteLine(name.Equals(name1));
            Console.WriteLine(name.CompareTo(name1));

            // To replace a char or string 
            Console.WriteLine(name.Replace("si", "#a#"));

            // find a character/substring inside a string
            // True/false depending upon the outcome
            Console.WriteLine(name.Contains("simran1"));

            // Find location of a character - make sure to use single quotes
            Console.WriteLine(name.IndexOf('s'));

            // Find location of a string - make sure to use double quotes
            Console.WriteLine(name.IndexOf("simran"));
            
            // To remove white spaces from both sides of the string
            Console.WriteLine(name.Trim());
            
            // Length is a property from String class
            Console.WriteLine($"Number of characters = {name.Length}");
            
            // index value starts from 0 
            Console.WriteLine(name[0]);

            Console.WriteLine(oddOrEven);
            
        }
    }
}
