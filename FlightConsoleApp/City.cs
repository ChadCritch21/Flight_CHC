/**
* This class represents a City with
* a name, lat and long.
* @author Rob Kelley
* @version 1.0;
* Lab04 - Solution
* SP19
*/

using System;

namespace FlightConsoleApp
{
    public class City
    {

        private readonly String name;
        private readonly double latitude;
        private readonly double longitude;

        /**
         * Empty-argument constructor to put 
         * object into a consistent state.
         */
        private City()
        {
            name = "";
            latitude = 0.0;
            longitude = 0.0;
        }//end constructor

        /**
         * Constructor to instantiate the object.
         * @param name
         * @param latitude
         * @param longitude
         */
        public City(String name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }//end constructor

        /**
         * Getter for name
         * @return
         */
        public String getName()
        {
            return name;
        }//end getName

        /**
         * Getter for latitude
         * @return
         */
        public double getLatitude()
        {
            return latitude;
        }//end getName

        /**
         * Getter for longitude
         * @return
         */
        public double getLongitude()
        {
            return longitude;
        }


        public override String ToString()
        {
            return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
        }
    }//end class
}