using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;
        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner is on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner is off");
        }

        public void SetAM()
        {
            Console.WriteLine("Tuner set to AM mode");
        }

        public void SetFM()
        {
            Console.WriteLine("Tuner set to FM mode");
        }

        public void setFrequency()
        {
            Console.WriteLine("Tuner set to frequency");
        }

    }
}
