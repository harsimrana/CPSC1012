namespace Week13Day03Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // build some houses
           House defaultHouse = new House();  // Default constructor

            House fancyHouse = new House(20, 4, 21, true);

            // order of my ints must match 

            House fancyHouseV2 = new House(numberRooms: 15, numberFloors: 3, 21, true);
            // optionally, we can named parameters to improve readability and hopefully reduce confusion


            // test my setter and getter methods
            fancyHouse.SetTemperature(25);

            Console.WriteLine("The temp of my fancy house is " + fancyHouse.GetTemperature());

            //test my properties 
            fancyHouseV2.Temperature = 3;

            Console.WriteLine($" The temp of my other fancy house is {fancyHouseV2.Temperature}");
            // Revision of previous class
            
            // I have number of house to track 
            // one way we can create an array 
            //House[] myProperties = new House[50];

            //List 

            List <House> myProperties = new List<House>(20);  // Create an empty
            // Add your houses into list
            // Using Add method
            myProperties.Add(defaultHouse);
            myProperties.Add( fancyHouse );
            myProperties.Add( fancyHouseV2);

            // Let's expand this one more

            string userChoice="";

            do
            {
                DisplayMenu();
                //Don't worry about exception handling in THIS program for now

                Console.Write("Please enter your choice: ");
                userChoice= Console.ReadLine();

                switch(userChoice) 
                {
                    case "N":
                        // Just for testing
                        //Console.WriteLine("Inside Add new house");
                        AddNewHouse(myProperties); // Passing List to method
                        break;
                    case "D":
                        DisplayHouseDetails(myProperties);
                        break;
                    case "E":
                        EditHouseDetails(myProperties);
                        break;
                    case "L":
                        LoadFromFile(myProperties);
                        break;
                    case "S":
                        SaveToFile(myProperties);
                        break;
                    case "Q":
                       // User wants to quit, do nothing
                        break;
                    default:
                        Console.WriteLine("Not an option. Try again with a valid option");
                        break;

                }

            } while (userChoice != "Q");
        }

        // Method to read data from file
        public static void LoadFromFile(List<House> list)
        {
            // Empty your list
            list.Clear(); // Remove all elements from the list


            // .tsv- tab separated values
            Console.Write(" Please enter file path and name to save the data [.txt, .csv, .tsv]: ");
            // Taking file path and name from user
            string fileName = Console.ReadLine();


            try
            {
                StreamReader reader = new StreamReader(fileName);

                //throw away the header line
                reader.ReadLine();

                // read it in, line by line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Console.WriteLine(line); // Just for testing

                    // Split up line, using that \t as delimiter
                    string[] magicArray = line.Split("\t");

                    House house = new House();
                    house.NumberRooms = int.Parse(magicArray[0]);
                    house.NumberFloors = int.Parse(magicArray[1]);
                    house.Temperature = double.Parse(magicArray[2]);
                    house.HasGarage = bool.Parse(magicArray[3]);

                    // add this object into list
                    list.Add(house);

                }

                //Close the stream
                reader.Close();

                // Success message to user
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File successfully Loaded. ");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error reading from file " + e.Message);
                Console.ResetColor();
            }

        }
        // Method to save data to file
        public static void SaveToFile(List<House> list)
        {                                                                   // .tsv- tab separated values
            Console.Write(" Please enter file path and name to save the data [.txt, .csv, .tsv]: ");
            // Taking file path and name from user
            string fileName = Console.ReadLine();

            try
            {
                //1. Open the file- In a try catch block
                // create our StreamWriter object- to write to the file
                StreamWriter writer= new StreamWriter(fileName);

                //2. Write Data to File

                //HardCode the header Line
                writer.WriteLine("Rooms\tFloors\tTemp\tGarage");
                
                //Writing data values from list into my file
                foreach (House element in list)
                {
                    writer.WriteLine($"{element.NumberRooms}\t{element.NumberFloors}\t{element.Temperature}\t{element.HasGarage}");
                }

                //3. Close the stream
                writer.Close();

                // Success message to user
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File successfully saved. " );
                Console.ResetColor();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Error saving to file " + ex.Message);
                Console.ResetColor();
            }

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Main Menu ");
            Console.WriteLine("=====================");
            Console.WriteLine("[N]ew House ");
            Console.WriteLine("[D]isplay House details");
            Console.WriteLine("[E]dit house");
            Console.WriteLine("[L]oad from file");
            Console.WriteLine("[S]ave to file");
            Console.WriteLine("[Q]uit");
        }
        // Sub Menu for House properties
        public static void DisplaySubMenu()
        {
            Console.WriteLine("House Editing Menu ");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Number of rooms ");
            Console.WriteLine("2. Number of Floors");
            Console.WriteLine("3. Temperature");
            Console.WriteLine("4. Add or remove Garage");
            Console.WriteLine("5. To return to main Menu");
        }

        // List will be passed as reference
        public static void AddNewHouse(List <House> houseList)
        {
            // Just for testing
            //Console.WriteLine("Inside Add New House Method");
            // Create a house using no-arguments Constructor
            House house = new House();

            bool isValid = false;

            // prompt the user for details and set each property
            // Number of rooms
            do
            {
                try
                {
                    // int GetValidInt(Label for user)
                    house.NumberRooms = GetValidInt("Enter # of rooms: ");
                    isValid = true;
                }
                catch(Exception e)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again");
                    Console.ResetColor();
                }

            } while (isValid == false);

            //changing it back to false
            isValid = false;

            // Taking number of floors
            do
            {
                try
                {
                    // int GetValidInt(Label for user)
                    house.NumberFloors = GetValidInt("Enter # of Floors: ");
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again");
                    Console.ResetColor();
                }

            } while (isValid == false);


            isValid = false;

            // Taking temp value
            do
            {
                try
                {
                    Console.Write("Enter temp. of house: ");
                    house.Temperature = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again");
                    Console.ResetColor();
                }

            } while (isValid == false);

            isValid = false;

            // Taking hasGarage value
            do
            {
                try
                {
                    Console.Write("House has Garage?? True/False: ");
                    house.HasGarage = bool.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again");
                    Console.ResetColor();
                }

            } while (isValid == false);


            // All house values have been taken
            // Add this object to your list
            
            //listName.Add( object/value);

            houseList.Add(house);

        }

        public static int GetValidInt(string message)
        {
            int userResponse = 0;

            bool isValid = false;

            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(message);
                    userResponse = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid number. Please try again");

                }
                finally // this runs no matter what 
                {
                    Console.ResetColor();
                }
                
            } while (!isValid);
            // All good: return the value
            return userResponse;  //Returning valid int value received from user 
        }// End Of method GetValidInt

        public static void DisplayHouseDetails(List<House> list)
        {
            // Reviewing Foreach Loop
            /*
            int[] numbers = { 1, 2, 3, 4, 5 };
            // using regular for loop
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine($" {numbers[i]}");
            }

            // Foreach 
            foreach (int elem in numbers)
            { // taking one element out of the collection 
                Console.WriteLine(elem);
            }
            */

            // Display house details for houses

            // iterate through each house in the list
            int counter = 1;
                    // element  in CollectionName
            foreach (House elem in list)
            {   //House # 1 has 2 rooms, 2 Floors 
                                    //Conditional Operator- Ternary operator
                string roomMessage = elem.NumberRooms > 1 ? " rooms" : "room";

                string floorMessage = elem.NumberFloors > 1 ? " floors" : "floor";

                string garageText = elem.HasGarage ? "has" : "does not have";
                
                Console.WriteLine($"House # {counter} has {elem.NumberRooms} {roomMessage}, {elem.NumberFloors} {floorMessage}, is {elem.Temperature} degree, and {garageText} a garage ");
                counter++;
            }
        }
         
        public static void EditHouseDetails(List<House> list) // List is always passed by reference
        {
            int houseNumber;
            // Display all house and ask the user to choose one
            DisplayHouseDetails(list);

            // Take user input for house number to be edited
            do
            {
                houseNumber = GetValidInt("Please select a house to edit: ");

                if (houseNumber <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is too small of a number. Must be 1 or greater");
                    Console.ResetColor();
                }
                else if (houseNumber > list.Count) // Count property will give current total number of elements in list
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"That is too large of a number. Must be {list.Count} or less");
                    Console.ResetColor();
                }

            } while (houseNumber < 1 || houseNumber > list.Count);

            // Ask the user which property they want to change


            int propertyChoice = 0;
            do
            {
                DisplaySubMenu(); // Sub menu for Different house properties

                propertyChoice = GetValidInt("Please enter your choice: ");

                switch (propertyChoice)
                {
                    case 1:
                        // -1 to find right index because index starts from 0
                        // House 1 - index 0
                        list[houseNumber -1 ].NumberRooms = GetValidInt("Please enter new # of rooms: ");
                        break;
                    case 2: // Number of floor
                        list[houseNumber - 1].NumberFloors = GetValidInt("Please enter new # of floors: ");
                        break;
                    case 3: // Instead of creating method, writing code directly
                        bool isValid = false;
                        do
                        {
                            try
                            {
                                Console.Write("Enter temp. of house: ");
                                list[houseNumber - 1].Temperature = double.Parse(Console.ReadLine());
                                isValid = true;
                            }
                            catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid entry. Please try again");
                                Console.ResetColor();
                            }

                        } while (isValid == false);
                        break;
                    case 4:
                        isValid = false;
                        do
                        {
                            try
                            {
                                Console.Write("Does House has a garage? True/ False: ");
                                list[houseNumber - 1].HasGarage = bool.Parse(Console.ReadLine());
                                isValid = true;
                            }
                            catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid entry. Please try again");
                                Console.ResetColor();
                            }

                        } while (isValid == false);
                        break;
                    case 5:
                        // GO back to previous menu
                        break;
                    default:
                        Console.WriteLine("Not an option. Try again with a valid option");
                        break;

                }

            } while (propertyChoice != 5);
        }
    }
}