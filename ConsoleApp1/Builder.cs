using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class ManualCar : Car { }
    public class AutomatoCar : Car { }

    public interface IBuilder
    {
        public IBuilder reset();
        public IBuilder setSeats(int number);
        public IBuilder setEngine(int engine);
        public IBuilder setTripComputer();
        public IBuilder setGPS(bool gps);
    }

    public class Car
    {
        public int Seats { get; set; }
        public int Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool GPS { get; set; }
    }

    public class CarManualBuilder : IBuilder
    {

        private ManualCar manual;

        public IBuilder reset()
        {
            this.manual = new ManualCar();
            return this;
        }

        public IBuilder setSeats(int number)
        {
            manual.Seats = number;
            return this;
        }

        public IBuilder setEngine(int engine)
        {
            manual.Engine = engine;
            return this;
        }

        public IBuilder setTripComputer()
        {
            return this;
        }

        public IBuilder setGPS(bool gps)
        {
            manual.GPS = gps;
            return this;
        }

        public ManualCar getResult()
        {
            return manual;
        }

    }

    public class CarAutoBuilder : IBuilder
    {

        private AutomatoCar automatoCar;

        public IBuilder reset()
        {
            this.automatoCar = new AutomatoCar();
            return this;
        }

        public IBuilder setSeats(int number)
        {
            automatoCar.Seats = number;
            return this;
        }

        public IBuilder setEngine(int engine)
        {
            automatoCar.Engine = engine;
            return this;
        }

        public IBuilder setTripComputer()
        {
            return this;
        }

        public IBuilder setGPS(bool gps)
        {
            automatoCar.GPS = gps;
            return this;
        }

        public AutomatoCar getResult()
        {
            return automatoCar;
        }

    }
}
