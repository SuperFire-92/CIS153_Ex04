using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_02_25_2024_ListsObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //We want to store information about a car
            //Car -> vin, make, model

            //Create a new instance of a car
            //The car will be comprised of - int, string, string (vin, make, model)
            //You must use the keyword new to reserve the correct memory
            //This line will call the constructor
            Car car1 = new Car();
            car1.setVin(12345);
            car1.setMake("Ford");
            car1.setModel("F-150");

            //Console.WriteLine(car1.getVin() + " " + car1.getModel());

            Car car2 = new Car();
            car2.setVin(15975);
            car2.setMake("Chevy");
            car2.setModel("Suburban");

            //Console.WriteLine(car2.getVin() + " " + car2.getModel());

            //Use the overloaded constructor
            //Set the information about car3 using the overloaded constructor
            Car car3 = new Car(78945, "Ford", "Edge");
            //Console.WriteLine(car3.getVin() + " " + car3.getModel());


            //Make a list structure to hold an unspecified amount of cars
            List<Car> listOfCars = new List<Car>();

            //Add a new car to the list
            listOfCars.Add(new Car());

            //Storing attributes about a car at a specific position in the list
            //you could use a counter for this instead, but thats boooriiiing
            listOfCars[listOfCars.Count() - 1].setVin(123);
            listOfCars[listOfCars.Count() - 1].setMake("Chevy");
            listOfCars[listOfCars.Count() - 1].setModel("Blazer");

            //Add a new car to the list
            listOfCars.Add(new Car());

            //Storing attributes about a car at a specific position in the list
            //you could use a counter for this instead, but thats boooriiiing
            listOfCars[listOfCars.Count() - 1].setVin(456);
            listOfCars[listOfCars.Count() - 1].setMake("Ford");
            listOfCars[listOfCars.Count() - 1].setModel("Bronco");

            //Add a new car to the list
            listOfCars.Add(new Car(789, "Chevy", "Bolt"));

            listOfCars.Add(car1);

            //Cyvlr through all elements in the list
            for (int i = 0; i < listOfCars.Count(); i++)
            {
                //get the car at position i in the list and return the vin and model
                Console.WriteLine(listOfCars[i].getVin() + " " + listOfCars[i].getModel());
            }
        }
    }
}
