namespace Week9Day3Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 9 Day 3 Demo 01
            // Passing an array to a method/function
            const int MAX_NUMBER_STUDENTS = 05;

            int[] marks = new int[MAX_NUMBER_STUDENTS];
            double averageMarks;

            //Give a title to your program
            PrintProgramTitle("Student Marks Mangement System");
            
            //Calling method to receive inputs from user : When array is passed to method, it is always passed by reference.
            InputMarksValues(marks);  // No [] for array when passing as an argument

            //Now we have values, calculate means average
            averageMarks = CalculateMeanMarks(marks);

            //We have values now from user, we can print the values
            Console.WriteLine("Student Marks Details ");

            PrintMarksValues(marks);

            PrintValue(averageMarks, "Means Average Marks for the class= ");

        }

        /****************************************************************
       * Function Name      : PrintProgramTitle
       * Purpose            : It will print program title in right format
       * Inputs             : Title: string type value 
       * Output             : NA [void]
       * ***************************************************************/
        static void PrintProgramTitle(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("===============================");
            Console.WriteLine("");
        }

        /*****************************************************************
        * Function Name     : InputMarksValues
        * Purpose           : It will receive marks values from the user
        * Inputs            : An array 
        * Output            : NA [void]
        * ****************************************************************/
        static void InputMarksValues(int[] stMarks)  // Make sure to use [] with array parameter
        {
            int i; // Loop controlling variable

            // Length property will provide the total number of elements in an array
            for (i = 0; i < stMarks.Length; i++)
            {
                Console.Write($" Enter the marks for Student #{i + 1} : ");
                stMarks[i] = int.Parse(Console.ReadLine());

            }
            return; // emtpy return statement will simply return the control back to user. It is default behaviour
        }

        /*********************************************************
       * Function Name  : PrintMarksValues
       * Purpose        : It will print marks values back to user
       * Inputs         : An array 
       * Output         : NA [void]
       * ********************************************************/

        static void PrintMarksValues(int[] stMarks) // Make sure to use [] with array parameter
        {
            int i; // Loop controlling variable

            // Length property will provide the total number of elements in an array
            for (i = 0; i < stMarks.Length; ++i)
            {
                Console.WriteLine($" Marks for student #{i + 1} = {stMarks[i]}");
            }
            return; // emtpy return statement will simply return the control back to user. It is default behaviour
        }

        /*********************************************************
      * Function Name  : CalculateMeanMarks
      * Purpose        : It will calculate mean average
      * Inputs         : An array 
      * Output         : Mean Average: double 
      * ********************************************************/
        static double CalculateMeanMarks(int[] stMarks)
        {
            double meansAvg; // To store mean average
            int sum = 0, i; // sum for finding sum of marks, and i is loop controller
            
            for (i = 0; i < stMarks.Length; ++i)
            { // adding all the values
                sum = sum + stMarks[i];
            }
            
            // Calculating mean avergae 
            meansAvg = (double)sum / stMarks.Length; // stMarks.Length will give number of elements in an array

            return meansAvg;
        }

        /*********************************************************
      * Function Name  : PrintValue
      * Purpose        : It will print the value passed to it
      * Inputs         : A value: double , Label: string 
      * Output         : NA [void] 
      * ********************************************************/
        static void PrintValue(double value, string label)
        { 
            Console.WriteLine($"{label} = {value}");
        }

    }
}