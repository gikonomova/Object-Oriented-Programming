using System;

//Create a struct Location that holds fields of type double latitude and longitude of a given location. 
//Create an enumeration Planet that holds the following constants:
//Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune.
//Add an enum field of type Planet.Encapsulate all fields.
//Validate data(search in Internet what are the valid ranges for latitude and longitude).
//Add a constructor that holds 3 parameters: latitude, longitude and planet.
//Override ToString() to print the current location in the format<latitude>, <longitude> - <location>

namespace Problem01.GalacticGPS
{
    public struct PlayingWithPlanets 
    {
        static void Main()
        {
            try
            {
                Location home = new Location(18.037986, 28.870097, Planet.Earth);
                Console.WriteLine(home);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Longitude must be between -180 and 180 degrees and latitude must be between -90 and 90 degrees.");              
            }
            Console.ReadLine();
        }
    }
}
