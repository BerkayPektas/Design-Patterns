using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Cd player is on");
        }

        public void Off()
        {
            Console.WriteLine("Cd player is off");
        }

        public void Eject()
        {
            Console.WriteLine("Cd player eject");
        }

        public void Pause()
        {
            Console.WriteLine("Cd player paused");
        }

        public void Play()
        {
            Console.WriteLine("Cd player playing");
        }

        public void Stop()
        {
            Console.WriteLine("Cd player stopped");
        }
    }
}
