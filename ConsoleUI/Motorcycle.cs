using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasTwoWheels { get; set; }

        public override void DriveA()
        {
            Console.WriteLine("bike is driving ");
        }
         public override void DriveV()
        {
            Console.WriteLine("bike Can drive");
        }
      


    }
}
