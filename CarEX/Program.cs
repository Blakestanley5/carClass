using System;
using System.Data.Common;

namespace CarEX
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2020;

            var myCar2 = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            Console.WriteLine($"Your cars info: Make:{myCar.Make} Model:{myCar.Model}, Year:{myCar.Year}.");

        }

    }
}
