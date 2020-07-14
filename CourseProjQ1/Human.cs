using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace CourseProjQ1
{
    class Human
    {
        string name;
        List<Item> items;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null name");
                name = value;
            }
        }

        public List<Item> Items
        {
            get { return items;}
            set { items = value; }
        }

        public Human(string name,  List<Item> items)
        {
            Name = name;
            Items = items;
        }

        public Human(string name)
        {
            Name = name;
            Items = new List<Item>();
        }

        public void addItem(Item item)
        {
            Items.Add(item);
        }

        public void removeItem(Item item)
        {
            Items.Remove(item);
        }

        public Item findItem(string name) // searching for the item by its name
        {
            foreach(Item item in Items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public string toString()
        {
            string tempItems = "Human Name: " + this.name + "\nItems:\n";
            foreach (Item item in Items)
            {
                tempItems += item.ToString() + "\n";
            }
            return tempItems;
        }
    }
}
