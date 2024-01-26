using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasFourSeats { get; set; }

        public override void DriveA()
        {
            Console.WriteLine("you are in a car");
        }

    }
}
