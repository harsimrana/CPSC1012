namespace Week6Day2Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 3 Day 2 : Demo 01- All loops

            // Print 1 to 10 numbers

            int i;
            i = 1; //1.  Initialization
            Console.WriteLine("Testing with while loop");
            while (i <= 10)  //2.  Condition 
            {
                Console.WriteLine($"{i}");

                i = i + 1;  // 3. Modification -
                // Shortcut ways: use any one of the followings
                // ++i;
                // i+=1; 
            }
            // Do the same with do while loop

            i = 1;  // 1. Initialization 
            Console.WriteLine("Testing with do- while loop");
            do
            {
                Console.WriteLine($"{i}");
                i += 1; //3. Modication 

            } while (i <= 10);  // 2. Condition

            Console.WriteLine("Testing with For loop");
            // Do it with for loop
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}");
            }





        }
    }
}
