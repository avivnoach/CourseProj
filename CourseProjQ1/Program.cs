using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseProjQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Post Malone"); // creating new human
            Human h2 = new Human("Pre Malone"); // creating new human
            ArrayList drivers = new ArrayList(); // setting drivers for the car
            drivers.Add(h1.Name); // adding drivers
            drivers.Add(h2.Name);
            List<string> pastOwners = new List<string>();
            pastOwners.Add(h2.Name);
            h1.addItem(new Vehicle(1, "Audi", 4, "Black", drivers, new Engine(200, 1600))); // creating items
            h1.addItem(new Vehicle(2, "Toyota", 4, "Blue", drivers, new Engine(150, 1400))); 
            h1.addItem(new Vehicle(3, "Suzuki", 4, "White", drivers, new Engine(200, 2000)));
            h1.addItem(new Jewelry(4, "necklace", 'M', "Gold", 24, pastOwners));
            h1.addItem(new Jewelry(5, "earring", 'L', "Gold", 9, pastOwners));
            h1.addItem(new Jewelry(6, "necklace", 'S', "Gold", 22, pastOwners));
            h1.addItem(new Clothing(7, "shirt", 100, 'L', "Grey"));
            h1.addItem(new Clothing(8, "pants", 'L', "Black"));
            h1.addItem(new Clothing(9, "hat", 70, 'M', "Red"));
            Console.WriteLine(h1.toString());
        }
    }
}
