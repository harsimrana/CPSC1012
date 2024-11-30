using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week13Day02Demos
{
    internal class Student
    {

        // Member variables
        //remeber: think about visiblity, initial value, static?

        private string _name;
        private int _id;
        private int _age =0;  // Default value
        private double _gpa = 0.0;


        // Constructors:
        // 1. Using class name
        // 2. No return data type
        // 3. Called automatically whenever you are going to create object
        public Student() // Default one
        {
            _name = "";
            _id = 0;
            _age = 0;
            _gpa = 0.0;
        }

        // Greedy Constructor
        public Student( string name, int id, int age, double gpa)
        {
            this._name = name; // this is optional: current object
            _id = id;
            _age = age;
            _gpa = gpa;
        }

        // Member methods
        public void PrintStudentDetails()
        {
            Console.WriteLine("Student Details ");
            Console.WriteLine("==================");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Student Id: {_id}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"GPA: {_gpa}");
        }


        //ToDo
        // Approach 1: creating getter and setter method
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {   // validation
            if (name.Length > 0 && name.Length <= 100)
            {
                _name = name;
            }
            else
            {
                throw new Exception("Name must be 0-100 characters");
            }
        }


        //Approach 2: creating properties

        public string Name  // Pascal naming notaion
        {
            get { return _name; }  // get and set are special keyword
            set {
                if (value.Length > 0 && value.Length <= 100)
                {
                    _name = value;  // value is a special keyword 
                }
                else {
                    throw new Exception("Name must be 0-100 characters");
                }
            }
        }

        // Later TODO: Create some other methods to do things


    }
}
