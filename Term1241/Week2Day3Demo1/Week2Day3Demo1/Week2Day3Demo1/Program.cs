namespace Week2Day3Demo1
{
    internal class Program
    {
        static void Main(string[] args) // Entry point of execution
        {
            //How to declare a varaible
            // DataType nameOfTheVarialbe = value;
            int classSize = 20;
            float stuMark = 45.5f;
            string firstName = "Harsimran", lastName = "Aulakh";

            Console.WriteLine("*************************************************************");
            Console.WriteLine("\t\tClass Size = " + classSize + " Student marks = " + stuMark);
            Console.WriteLine("Name = " + firstName + " " + lastName);
            //String interpolation- directly insert your variable inside your string
            // {}, $ are crucial in that case
            Console.WriteLine($"\t\tClass Size = {classSize} Student marks = {stuMark}");
            Console.WriteLine($"Name = {firstName} {lastName}");

        }
    }
}