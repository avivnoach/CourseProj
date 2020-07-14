using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProjQ1
{
    class Engine
    {
        int horsePower;
        int volume;

        public int HorsePower
        { 
            get { return horsePower; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid horse power");
                horsePower = value;
            }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Invalid volume");
                }
                volume = value;
            }
        }

        public Engine(int horsePower, int volume)
        { HorsePower = horsePower; Volume = volume; ; }

        public string toString()
        {
            return "Volume: " + Volume + ", Horse Power: " + HorsePower;
        }
    }
}
