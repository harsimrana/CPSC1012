using System;

namespace Week6Day3Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 6=> Day 3: Demo 02
            int menuChoice = 0;
            char userChoice='N';
            bool isValid = true;

            do // Outer loop to control whether user would like to perform this again.
            {
                Console.WriteLine("Press 1: For addition ");
                Console.WriteLine("Press 2: For Subtraction ");
                Console.WriteLine("Press 3: For Multiplication ");
                Console.WriteLine("Press 4: For Division ");

                isValid = true;

                while (isValid)  // Logic to control first input
                {
                    try
                    {
                        Console.Write("Enter your choice: ");
                        menuChoice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Don't try to be a smart user!! Enter a right response!!");
                    }
                    // Write your logic for Calculator
                    switch (menuChoice)
                    {
                        case 1:
                            //write your logic for addition
                            Console.WriteLine($"You have pressed {menuChoice}");
                            isValid = false;
                            break;
                        case 2:
                            //write your logic for sub
                            Console.WriteLine($"You have pressed {menuChoice}");
                            isValid = false;
                            break;
                        case 3:
                            //write your logic for Mul
                            Console.WriteLine($"You have pressed {menuChoice}");
                            isValid = false;
                            break;
                        case 4:
                            //write your logic for divisio
                            Console.WriteLine($"You have pressed {menuChoice}");
                            isValid = false;
                            break;
                        default:
                            Console.WriteLine("Wrong Choice:Enter a number between 1 and 4");
                            isValid = true;
                            break;
                    }
                }

                isValid = true;
                
                while (isValid) // Nested loop to control user behaviour for input
                {
                    try
                    {
                        Console.Write("Do you like to perform it again? [Y, N]: ");
                        userChoice = char.Parse(Console.ReadLine());
                        if(userChoice=='Y' || userChoice == 'y' || userChoice == 'n' || userChoice == 'N')
                        {
                            isValid = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        isValid = true;
                        Console.WriteLine("Don't try to be a smart user!! Enter a right response!!");
                    }
                }

            } while (userChoice == 'Y' || userChoice == 'y');  // Semi-colon is required with do while

            Console.WriteLine("Good bye! Thank you for using my calculator");

        }
    }
}