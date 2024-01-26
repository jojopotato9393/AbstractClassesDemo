using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "2000-2024";
        public string Make { get; set; } = "ford";
        public string Model { get; set; } = "flex";

        public abstract void DriveA();
        public virtual void DriveV()
        {
            Console.WriteLine("can drive");
        }

    }

   
}
