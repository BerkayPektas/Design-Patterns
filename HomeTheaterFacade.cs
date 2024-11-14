using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _lights;
        private PopcornPopper _popcornPopper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer, Projector projector, Screen screen, TheaterLights lights, PopcornPopper popcornPopper)
        {
            _amplifier = amp;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popcornPopper.On();
            _popcornPopper.Pop();

            _lights.Dim(10);

            _screen.Down();

            _projector.On();
            _projector.WideScreenMode();

            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);

            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down movie theater...");
            _popcornPopper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
        }
    }
}
