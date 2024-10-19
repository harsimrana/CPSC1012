using System;

namespace Week7Day3Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Week 7: Day 3
            // Program to find a number inside a array.
            /* Planning steps:
                1. Create an array. -- Test it by hard coding the values first
                2. Ask user for number -- Skip it first
                3. Ask the user for a number to be searched -- Variable
                4. Processing: Find location of the element
                    4a. Traverse the array 
                    4b. Check a condition [if condition]
                        if match is found- store the location - Variable
                        if no match, keep traversing 
                5. Print the location back to user or no element found
             */
            //Step 1:
            // Uncomment the following line to if you need to test it with hard coded values
             //int[] list = { 3, 5, 7, 10, 34, 67, 87, 20 };
            /*Mermory representation of this array
             * _____________________________________
             *| 3 | 5 | 7 | 10 | 34 | 67 | 87 | 20|
             *_____________________________________
             *  0   1   2   3    4    5    6    7
             * 
             */
            // Comment out the following line if you need to test it with hard coded values
            int[] list = new int[25]; // physical size 25 element
            int findNumber=0, i, locationOfElement = -1 , numberOfElements;
            bool isValid = true;
            
           
            //Title of the program
            Console.WriteLine("Value Finder");
            Console.WriteLine("===============");
            Console.WriteLine("");

            //Generate a random number for number of elements
            Random r = new Random();
            //numberOfElements = r.Next(26); // Random number between 1 and 25 
            numberOfElements = r.Next(1, 26); // Random number between 1 and 25 

            // Testing the value
            //Console.WriteLine($"Random number: {numberOfElements}");
            
            //Step 2: Take values from user 
            //Loop to input values from user and store them in array
            for (i = 0; i < numberOfElements; ++i)
            {
                isValid = true;
                while (isValid)
                {
                    try
                    {
                        Console.Write($"Enter {i + 1} element: ");
                        list[i] = int.Parse(Console.ReadLine());
                        isValid = false;
                    }
                    catch(Exception e)
                    {
                        isValid = true;
                    }
                }
            }


            isValid = true;
            // Step 3: Ask the user for a number to be searched -- Variable
            while (isValid)  // Forcing the user to input numerical value
            {
                try
                {
                    Console.Write("Enter the number to be searched: ");
                    findNumber = int.Parse(Console.ReadLine());
                    isValid = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input numerical value only");
                    isValid = true; 
                }
            }
            //Step 4 Processing: Find location of the element
            // 4a.Traverse the array
            // Length property - will give you number of elements in the list
            //for (i = 0; i < list.Length; ++i)  // Physical size of the array
            for (i = 0; i < numberOfElements; ++i)  // Logical size 
            {           
                //4b.Check a condition [if condition]
                //if match is found- store the location - Variable
                if (list[i] == findNumber)
                {
                    locationOfElement = i;
                    break; 
                }
                //if no match, keep traversing 

            }

            //Step 5: 5. Print the location back to user or no element found
            if (locationOfElement == -1) // No match
            {
                Console.WriteLine($"{findNumber} is not in the list");
            }
            else // Match is found
            {
                Console.WriteLine($"{findNumber} is found at index position {locationOfElement}");
            }
        }
    }
}