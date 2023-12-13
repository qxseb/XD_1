using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD__2023
{
    internal class Vehicle
    {
        private string engine_type = "gas";
        private string color;
        private string name;
        private int maxSpeed;
        private int year;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1980)
                {
                    throw new Exception("Please pass a correct value!");
                } else
                {
                    year = value;
                }
            }
        }

        public string Engine_Type
        {
            get { return engine_type; }
            set { engine_type = value; }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
