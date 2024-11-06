using System.ComponentModel.Design;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Constants for vehicle fuel effficincy
            const double YOUR_VEHICLE_EFFECIENCY = 11.9; //L per 100km
            const double FRIEND_VEHICLE_EFFECIENCY = 8.7; //L per 100km

            bool continueCalculation = true;
            Random random = new Random();

            while (continueCalculation)
            {
                //Getting the trip distance input
                double tripDistance = GetTripDistance();

                //Getting thye vehicle choice input
                double fuelefficiency = GetVehicleChoice(YOUR_VEHICLE_EFFECIENCY, FRIEND_VEHICLE_EFFECIENCY);

                //simulating the fuel price 
                double fuelPrice = random.NextDouble() * (2.00 - 1.40) + 1.40;
                fuelPrice = Math.Round(fuelPrice, 2); //round to decimal places

                //calculating fuel needed and cost
                double fuelNeeded = (fuelefficiency / 100) * tripDistance;
                double fuelCost = fuelNeeded * fuelPrice;

                //Calculating food cost based on trip distance
                double foodCost = CalculateFoodCost(tripDistance);

                //Calculating total cost
                double totalcost = fuelCost + foodCost;

                //Display the results
                Console.WriteLine("\nTrip length: {0} km", tripDistance);
                Console.WriteLine("Fuel efficiency: {0} L per 100km", fuelefficiency);
                Console.WriteLine("Fuel needed: {0} L", Math.Round(fuelNeeded, 2));
                Console.WriteLine("fuelNeeded price: ${0} per L", fuelPrice);
                Console.WriteLine("Fuel cost: ${0}", Math.Round(fuelCost, 2));
                Console.WriteLine("Food Cost: ${0}", foodCost);
                Console.WriteLine("Total cost: ${0}", Math.Round(totalcost, 2));

                //Asking the user if they want to do another calculation
                continueCalculation = AskToContinue();


            }
        }

        static double GetTripDistance()
        {
            double tripDistance;
            while (true)
            {
                Console.Write("Please enter the trip distance in whole kilometers: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out tripDistance) && tripDistance > 0)
                {
                    return tripDistance;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter the distance whole kilometers: ");
                }


            }
        }

        //Method to get the vehicle choice (your vehicle or friend's)
        static double GetVehicleChoice(double yourVehicleEfficiency, double friendVehicleEfficiency)

        {
            while (true)
            {
                Console.Write("Will you be taking [y]our vehicle or your [f]riend's? (y/f): ");
                string vehicleChoice = Console.ReadLine().ToLower();

                if (vehicleChoice == "y")
                {
                    return yourVehicleEfficiency;
                }
                else if (vehicleChoice == "f")
                {
                    return friendVehicleEfficiency;
                }
                else
                {
                    Console.WriteLine("Please enter one character only.");
                }
            }


        }

        //Method to calculate food cost based on trip distance
        static double CalculateFoodCost(double tripDistance)
        {
            if (tripDistance < 2000)
            {
                return 30;
            }
            else if (tripDistance < 500)
            {
                return 50;
            }
            else if (tripDistance < 1000)
            {
                return 80;
            }
            else
            {
                return 120;
            }
        }

        //Method to ask if the usser wants to continue
        static bool AskToContinue()
        {
            Console.Write("Would you like to do another calculation? \nEnter Y to continue or any other key to Exit: ");
            string continueInput = Console.ReadLine().ToLower();
            return continueInput == "y";
        }



    }
}