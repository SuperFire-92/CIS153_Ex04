using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_02_25_2024_ListsObjects
{
    internal class Car
    {
        //Global or class variables
        //These will always be private
        //private members
        //public functions

        //private means that these variables/functions can only be accessed
        //in the class they were created.
        //public means that these variables/functions can be accessed in any
        //c# file in the project

        //we will edit these variables using getters and setters.
        private int vin;
        private string make;
        private string model;

        //Constructor - has the same name as the class
        //has no return type
        public Car()
        {
            Console.WriteLine("Car Created");
        }

        //Overloaded constructor - has the same name as the class
        //Take one or multiple arguments
        public Car(int v, string m, string mo) 
        {
            vin = v;
            make = m;
            model = mo;
        }


        //======SETTERS======
        public void setVin(int v)
        {
            vin = v;
        }

        public void setMake(string m)
        {
            make = m;
        }

        public void setModel(string m)
        {
            model = m;
        }
        //======END SETTERS==

        //======GETTERS======
        public int getVin()
        {
            return vin;
        }

        public string getMake()
        {
            return make;
        }

        public string getModel()
        {
            return model;
        }
        //======END GETTERS==
    }
}
