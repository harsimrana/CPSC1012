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

            House fancyHouseV2 = new House(numberRooms: 20, numberFloors: 4, 21, true);
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

            List <House> myProperties = new List<House>();  // Create an empty
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

                Console.WriteLine("Please enter your choice: ");
                userChoice= Console.ReadLine();

                switch(userChoice) 
                {
                    case "N":
                        //AddNewHouse(myProperties); // Passing List to method
                        break;
                    case "D":
                        // DisplayHouseDetails(myProperties);
                        break;
                    case "E":
                        // EditHouseDetails(myProperties);
                        break;
                    case "L":
                        // LoadFromFile(myProperties);
                        break;
                    case "S":
                        // SaveToFile(myProperties);
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

        public static void AddNewHouse(List <House> houseList)
        {
            // Create a house using no-arguments Constructor
            House house = new House();

            bool isValid = false;

            // prompt the user for details and set each property

            do
            {
                try
                {
                    Console.Write(" Enter # rooms: ");

                    house.NumberRooms = int.Parse(Console.ReadLine()); 
                }
                catch(Exception e)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again");
                    Console.ResetColor();
                }

            } while (isValid == false);

        }
    }
}