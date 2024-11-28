using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Day02Demos
{
    internal class Dog
    {
        
        //some variable - State
        private string _name;
        private string _breed;
        private int _age;
        private string _color;

        // Methods- Behaviour of object
        // Constructor
        public Dog() // Default constructor is always there
        { // We are overriding it
            _name = "";
            _breed = "";
            _age = 0;
            _color = "white";
        }
        //Constructor Overloading 
        public Dog(string name, string breed, int age, string color) // Default constructor is always there
        { // We are overriding it
            // validate data and assign those values to states
            _name = name;
            _breed = breed;
            _age = age;
            _color = color;

        }
        // Some methods
        public void PrintDetails()
        {
            Console.WriteLine("Dog Details ");
            Console.WriteLine("==================");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Breed: {_breed}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Color: {_color}");
        }
        public void Bark()
        {
            Console.WriteLine($"{_name} is barking now");
        }
        // Eat()
        // Walk()

    }
}
