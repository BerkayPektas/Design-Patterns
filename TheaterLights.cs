using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater lights are on");
        }

        public void Off()
        {
            Console.WriteLine("Theater lights are off");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Dim lights to {value}");
        }
    }
}
