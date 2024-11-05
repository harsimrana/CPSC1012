namespace Week10Day1Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading and writing Data to/from files

            // Creating and opening a file
            /* StreamWriter writer = new StreamWriter(@"C:\Users\harsimrana\Documents\Data\data.txt");

             // Writing to file
             writer.WriteLine("Print something on screen");
             writer.WriteLine("Second line into the file");

             // Close your file
             writer.Close();
            */
            string path = @"C:\Users\harsimrana\Documents\Data\data.txt";
            
            // Asking user to provide file path
            Console.Write("Enter the file path to read data from: ");
            path = Console.ReadLine();
            
            // path variable to hold path of the file.

            if (File.Exists(path))  // To check whether file exists or not
            {
                // Let's read the data from file
                StreamReader reader = new StreamReader(path);

                // Unknown length data from file
                //EndOfStream property will give you true or false value
                // If end of file reaches, it will return true otherwise false
                while (reader.EndOfStream == false)
                {
                    // reading single line from your file at a time
                    string line = reader.ReadLine();

                    //Print the line to screen
                    Console.WriteLine(line);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("File does not exists");
            }

            
        }
    }
}
