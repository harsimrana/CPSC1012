namespace Week14Day02Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 4, 5, 7 };
            int[] values1 = { 14, 15, 17 };

            // Lists 
            // emtpy list to hold int values
            List<int> numbers = new List<int>(20); // Maximum 20 Elements

            // adding threee int values into the list
            numbers.Add(6);
            numbers.Add(5);
            numbers.Add(11);
            // adding collection values[array ] into list
            numbers.AddRange(values);


            //Insert a new element at a specific position in the list
                        // Pos, element  
            numbers.Insert( 2, 99);

            // insert a range of values at a specific poistion 
            numbers.InsertRange(1, values1);

            //Remove an element from list 
                        // elem
            numbers.Remove(17);

            // Remove an element at a specific index position
            //              index
           numbers.RemoveAt(0);

            // Remove multiple element in a single go
                            // Startindex,  numberof element
           numbers.RemoveRange(2       ,  3);

            int elemFind = 11;
            // Check if an element exists in the list
                                // element
            int idx = numbers.IndexOf(elemFind);
            // IndexOF() will find an element in the list.
            // It will return index if element found
            // Otherwise it will return -1
            if (idx > 0)
            {
                Console.WriteLine($"{elemFind} is found at index position {idx}");
            }
            else {
                Console.WriteLine($"{elemFind} is not found in the list");
            }
            
            // Count    - current number of elements in the list
            // Capacity - Total capacity of the list

            Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}");

            Console.WriteLine($"Printing elements using regular for Loop");
            // Iterating through list using regular for loop
            for (int i = 0; i < numbers.Count; ++i)
            {  // Still can target index 
                Console.WriteLine($" {numbers[i]}");
            }
            // To sort a list, use sort() mehod
            numbers.Sort();
            // Reverse the list
            numbers.Reverse();

            Console.WriteLine($"Printing elements using Foreach Loop");
            //Iterating through list using foreach loop
            foreach (int elem in numbers)
            {
                Console.WriteLine($"{elem}");
            }

            // Convert your list into an array
            int[] newArray = numbers.ToArray();

            Console.WriteLine($"Printing elements using Foreach Loop from an array");
            foreach (int elem in newArray)
            {
                Console.WriteLine($"{elem}");
            }

            // Remove all elements from the list

            numbers.Clear();

        }
    }
}
