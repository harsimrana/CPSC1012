namespace Week06ClassDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week06 Day 1 Demo 01

            int a = 0, b = 0;

            try
            {
                //Prompt the user fo inputs
                Console.Write("Enter the first number:");
                a = int.Parse(Console.ReadLine());

                Console.Write("Enter the Second number:");
                b = int.Parse(Console.ReadLine());

                // If a > b, true then - A is greater
                // Else - false then - B is greater
                if (a > b)
                {  // True Part 
                    Console.WriteLine($" {a} is greater");
                }
                else
                { //false part will go here
                    Console.WriteLine($"{b} is greater ");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("As a good user, provide intergers values only");
                Console.WriteLine("Re-run the program one more time");
            }
            



        }
    }
}
