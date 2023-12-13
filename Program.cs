using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD__2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("MyCar", "Red", 2023, 200, "electric");
            Console.WriteLine(myCar);

            Console.ReadKey();
        }
    }
}
