namespace Week10Day2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a CSV file  - Comma separated values
            // Record - Row
            string filePath = @"C:\Users\harsimrana\Documents\Data\studentdata.csv";
            try
            {
                // Open your file
                StreamWriter writer = new StreamWriter(filePath);

                //Write Record [csv] into your file
                // Header row
                writer.WriteLine($"SN,Name,Email ");
                // Actual Data
                writer.WriteLine($"1,Simran,simran@nait.ca ");

                // Close the file
                writer.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(" Technical issue try again");
            }
        }
    }
}
