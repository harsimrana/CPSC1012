namespace Week13Day02Demos
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Dog class
            Dog lily = new Dog();  // Calling Defautl constructor 

            // Print dog details
            lily.PrintDetails();

            // Let's use another constuctor 
            Dog myDog = new Dog("Tommy", "German Shepherd", 7, "Brown");
            //Calling Greedy Constructor

            myDog.PrintDetails();

            //Console.WriteLine("Simran");
           
        }
    }
}
