using System;
using System.Text;

//Create a struct Location that holds fields of type double latitude and longitude of a given location. 
//Create an enumeration Planet that holds the following constants:
//Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune.
//Add an enum field of type Planet.Encapsulate all fields.
//Validate data(search in Internet what are the valid ranges for latitude and longitude).
//Add a constructor that holds 3 parameters: latitude, longitude and planet.
//Override ToString() to print the current location in the format<latitude>, <longitude> - <location>

namespace Problem01.GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be between -90 and 90 degrees inclusive.");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude must be between -180 and 180 degrees inclusive.");
                }
                this.longitude = value;
            }
        }
        public Planet Planet { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet));            
            return sb.ToString();
        }
    }
}
