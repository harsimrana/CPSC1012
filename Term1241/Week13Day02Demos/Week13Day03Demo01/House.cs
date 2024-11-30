using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Day03Demo01
{
    internal class House
    {
        // Static fields would go first, if we had any

        // Instance/ object fields, AKA member varaibles:
        //determine visibility, data types, names, initial value
        // visibility should always be private

        // MEMBER VARIABLES- FIELDS - STATE
        private int _numberRooms; // ints default to 0
        private int _numberFloors = 1;
        private double _temperature = 19;
        private bool _hasGarage; // bools default to false

        // Approach : PROPERTIES to allow access to variable 

        public int NumberRooms
        { 
            get { return _numberRooms; } 
            set {
                if (value > 0) 
                { 
                    _numberRooms = value;
                }
                else
                {
                    throw new Exception("Rooms must be > 0");
                }
            }
        }

        public int NumberFloors
        { 
            get { return _numberFloors;}
            set
            {
                if (value > 0)
                {
                    _numberFloors = value;
                }
                else
                {
                    throw new Exception("Floors must be >0");
                }
            }
        }

        public double Temperature
        {
            get { return _temperature; }
            set { 
                if(value <=0)
                {
                    throw new Exception("Temp must be above 0");
                }
                else if (value > 50) {
                    throw new Exception("Temp must be below 50.");
                }
                else
                {
                    _temperature = value;
                }
            }
        }

        public bool HasGarage
        {
            //get; set; // shortcut form to create property
            get { return _hasGarage; }
            set { _hasGarage= value; }
        }


        //MEMBER METHODS

        // no-argument constructor:
        public House() { 
        
        }

        //Greedy constructor: all the params!
        public House(int numberRooms, int numberFloors, double temp, bool hasGarage)
        { 
            NumberRooms= numberRooms;
            NumberFloors= numberFloors;
            Temperature= temp;
            HasGarage= hasGarage;
        }

        // Approach 2: getter & setter methods

        public double GetTemperature()
        { 
            return _temperature;
        }
        public void SetTemperature(double temp)
        {
            if (temp <= 0)
            {
                throw new Exception("Temp must be above 0");
            }
            else if (temp > 50)
            {
                throw new Exception("Temp must be below 50.");
            }
            else
            {
                _temperature = temp;
            }
        }

        //Similarly add methods for other varible
        
        // Later
        // add some methods
        // Renovate(), Decorate()// AddingFurniture()

    }
}
