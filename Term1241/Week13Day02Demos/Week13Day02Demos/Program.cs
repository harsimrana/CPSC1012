namespace Week13Day02Demos
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object/ instance of Dog class
            Dog lily = new Dog();  // Calling Defautl constructor 

            // Print dog details
            lily.PrintDetails();

            // Let's use another constuctor 
            Dog myDog = new Dog("Tommy", "German Shepherd", 7, "Brown");
            //Calling Greedy Constructor

            myDog.PrintDetails();

            //Console.WriteLine("Simran");


            // Create an object of Student class

            Student s1 = new Student(); // Calling default Constructor

            s1.PrintStudentDetails();
            
            // Name arguments to avoid order of arguments
            Student s2 = new Student(id: 1, name: "Simran", age: 40, gpa: 4.5);

             s2.PrintStudentDetails();

            try
            {
                s2.SetName("Harsimranjot");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            Console.WriteLine($"Student = {s2.GetName()}");

            try
            {
                s2.Name = "";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            Console.WriteLine($"Student = {s2.Name}");


            // Create an array of Student class, containing 10 students

            Student[] studentList = new Student[10];
            

        }
    }
}
