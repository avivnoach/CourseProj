using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProjQ1
{
    class Clothing : Item, Equality<Clothing>
    {
#pragma warning disable CS0649 // Field 'Clothing.size' is never assigned to, and will always have its default value
        char size;
#pragma warning restore CS0649 // Field 'Clothing.size' is never assigned to, and will always have its default value
        string color;

        public char Size
        {
            get { return size; }
            set
            {
                if (value != 'S' && value != 'M' && value != 'L') 
                    throw new Exception("Invalid size");
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

        public Clothing(int id, string name, float price, char size, string color) : base(id, name, price)
        { Size = size; Color = color; ; }

        public Clothing(int id, string name, char size, string color) : base(id, name)
        { Size = size; Color = color; ; }

        public Clothing(Clothing other) : base(other.ID, other.Name, other.Price)
        { Size = other.Size; Color = other.Color; ; }

        public int compareTo(Clothing other) // function compares two clothes by their price
        {
            if (this.Price < other.Price)
                return -1;
            else if (this.Price > other.Price)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        { return "Name: " + Name + ", id: " + ID + ", price: " + Price + ", Size: " + Size + ", color: " + Color; ; }

        public void expended() // if the clothes expended, they changed the size
        {
            if (this.Size == 'S')
                this.Size = 'M';
            else if (this.Size == 'M')
                this.Size = 'L';
        }

        public void shrinked()
        {
            if (this.Size == 'L')
                this.Size = 'M';
            else if (this.Size == 'M')
                this.Size = 'S';
        }

        public bool equals(Clothing obj)
        {
            if(this.Name == obj.Name && this.ID == obj.ID && this.Price == obj.Price && this.Color == obj.Color && this.Size == obj.Size)
            {
                return true;
            }
            return false;
        }

        public override string usageData()
        {
            return "this is a clothing item, people wear it to get warm and to avoid nudity";
        }
    }
}
