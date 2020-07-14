using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProjQ1
{
    abstract class Item
    {
        int id;
        string name;
        float price;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null name");
                name = value;
            }
        }


        public float Price
        {
            get { return price; }
            set { if (value < 0) throw new ArgumentException("Negative value of price is not allowed"); price = value; }
        }

        public int ID
        {
            get { return id; }
            set { if (value == 0) throw new ArgumentException("Null value of id"); id = value; }
        }


        public Item(int id, string name, float price)
        { ID = id; Name = name; Price = price; ; }

        public Item(int id, string name)
        { ID = id; Name = name; price = 0.0f; }


        // string with information about Item's usage
        public abstract string usageData();

        public override string ToString()
        { return name + " and id " + id; }
    }

}
