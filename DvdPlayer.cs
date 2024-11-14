using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Dvd Player is on");
        }

        public void Off()
        {
            Console.WriteLine("Dvd Player is off");
        }

        public void Eject()
        {
            Console.WriteLine("Dvd Player eject");
        }

        public void Pause()
        {
            Console.WriteLine("Dvd Player paused");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Dvd player playing movie: {movie}");  
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("Dvd Player surround audio set");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Dvd Player two channel audio set");
        }

        public void Stop()
        {
            Console.WriteLine("Dvd Player stopped");
        }
    }
}
