using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD__2023
{
    internal class Car : Vehicle
    {
        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            Name = nameName;
            Color = colorName;
            Year = yearValue;
            MaxSpeed = maxSpeedValue;
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type) : this(nameName, colorName, yearValue, maxSpeedValue)
        {
            Engine_Type = eng_type;
        }

        public Car(string nameName)
        {
            Name = nameName;
        }

        public override string ToString()
        {
            return $"Car Name: {Name}, Color: {Color}, Year: {Year}, Engine Type: {Engine_Type}";
        }
    }
}
