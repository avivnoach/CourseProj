using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CourseProjQ1
{
    class Jewelry : Clothing, Equality<Jewelry>
    {
        int karat;
        List<string> pastOwners; // if the jewelry goes in the family

        public int Karat
        {
            get { return karat; }
            set
            {
                if (value < 9 || value > 24) // karat values are always between 9 and 24
                    throw new Exception("Invalid karat value");
                karat = value;
            }
        }

        public List<string> PastOwners
        {
            get { return pastOwners; }
            set { pastOwners = value; }
        }

        public Jewelry(int id, string name, float price, char size, string color, int karat, List<string> owners) : base(id, name, price, size, color)
        { Karat = karat; PastOwners = owners; }

        public Jewelry(int id, string name, char size, string color, int karat, List<string> owners) : base(id, name, size, color)
        { Karat = karat; PastOwners = owners; }

        public void Add(string endower)
        {
            pastOwners.Add(endower);
        }

        public void inheritToChild(string parentName)
        {
            Add(parentName);
        }

        public void addKarat(int karatAmout)
        {
            if (Karat + karatAmout > 24)
                throw new Exception("Karat cannot be above 24");
            Karat += karatAmout;
        }

        public void subKarat(int karatAmout)
        {
            if (Karat + karatAmout < 9)
                throw new Exception("Karat cannot be under 9");
            Karat -= karatAmout;
        }

        public int compareTo(Jewelry other) // comparing by karat
        {
            if (this.Karat < other.Karat)
                return -1;
            else if (this.Karat > other.Karat)
                return 1;
            else
                return 0;
        }

        public bool equals(Jewelry obj)
        {
            return this.Name == obj.Name && this.ID == obj.ID && 
                this.Price == obj.Price && this.Color == obj.Color &&
                this.Size == obj.Size && this.Karat == obj.Karat &&
                this.PastOwners == obj.PastOwners;
        }

        public override string ToString() 
        {
            string tempPastOwners = "";
            foreach (string owner in PastOwners)
            {
                tempPastOwners += owner + ", ";
            }
            return "Name: " + Name + ", id: " + ID + 
                ", price: " + Price + ", Size: " + Size +
                ", color: " + Color + ", Karat: " + Karat + ", past owners: " + tempPastOwners ; ; }
    }
}
