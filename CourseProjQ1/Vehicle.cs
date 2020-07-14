using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Transactions;

namespace CourseProjQ1
{
    class Vehicle : Item, Equality<Vehicle>
    {
        int wheelNumber; // can be 2/3/4 (2,3 in case of motorbike)
        string color;
        Engine engine;
        ArrayList drivers;

        public int WheelNumber
        {
            get { return wheelNumber; }
            set
            {
                if (value < 2 || value > 4) throw new Exception("Invalid number of wheels");
                wheelNumber = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null color");
                color = value;
            }
        }

        public ArrayList Drivers
        {
            get { return drivers; }
            set { this.drivers = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Vehicle(int id, string name, float price, int wheelNum, string color, ArrayList driversList, Engine e) : base(id, name, price) // full arguments constructor
        { Color = color; WheelNumber = wheelNum; Drivers = driversList; Engine = e; }

        public Vehicle(int id, string name, int wheelNum, string color, ArrayList driversList, Engine e) : base(id, name) // constructor without the vehicle's price
        { Color = color; WheelNumber = wheelNum; Drivers = driversList; Engine = e; }

        public Vehicle(Vehicle other) : base(other.ID, other.Name, other.Price) // copy constructor
        { Color = other.Color; WheelNumber = other.WheelNumber; Drivers = other.Drivers; Engine = other.Engine; }

        public int compareTo(Vehicle other) // function compares two vehicles by their price
        {
            if (this.Price < other.Price)
                return -1;
            else if (this.Price > other.Price)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            string tempDrivers = "";
            foreach (string driver in drivers) // casting the arrayList to string
            {
                tempDrivers += driver + ", ";
            }
            return "Name: " + Name + ", id: " + ID + ", price: " + Price + ", color: " + Color + ", Number of wheels: " + WheelNumber + ", drivers: " + tempDrivers + ", Engine: " + Engine.toString();
        }

        public void valueAscent(int percentage) // vehicles price getting higher by percents
        {
            if (percentage < 0) throw new Exception("Invalid percentage");
            this.Price += this.Price + ((this.Price / 100) * percentage);
        }

        public void valueDesent(int percentage)// vehicles price getting lower by percents
        {
            if (percentage < 0 || percentage > 100) throw new Exception("Invalid percentage");
            this.Price += this.Price - ((this.Price / 100) * percentage);
        }

        public bool equals(Vehicle obj)
        {
            return this.Name == obj.Name && this.ID == obj.ID && this.Price == obj.Price && this.Color == obj.Color && this.WheelNumber == obj.WheelNumber;
        }

        public override string usageData()
        {
            return "this is a vehicle, which used for getting people from one place to another";
        }
    }
}
