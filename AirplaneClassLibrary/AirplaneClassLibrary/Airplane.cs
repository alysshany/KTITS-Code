using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneClassLibrary
{
    public class Airplane
    {
        private string _destinationName;
        private string _flightNumber;
        private DateTime _departureTime;

        public string DestinationName 
        { 
            get { return _destinationName; } 
            set { _destinationName = value; } 
        }

        public string FlightNumber 
        { 
            get { return _flightNumber; } 
            set { _flightNumber = value;} 
        }

        public DateTime DepartureTime 
        { 
            get { return _departureTime; } 
            set { _departureTime = value;} 
        }

        public Airplane(string destination, string flightNumber, DateTime departureTime)
        {
            DestinationName = destination;
            FlightNumber = flightNumber;
            DepartureTime = departureTime;
        }

        public static bool operator ==(Airplane p1, Airplane p2) 
        {
            if (p1.DepartureTime == p2.DepartureTime) { return true; } else { return false; } 
        }

        public static bool operator !=(Airplane p1, Airplane p2) 
        {
            if (p1.DepartureTime != p2.DepartureTime) { return true; } else { return false; }
        }

        public override bool Equals(object obj)
        {
            return obj is Airplane airplane &&
                   DepartureTime == airplane.DepartureTime;
        }

        public override int GetHashCode()
        {
            return 1399961614 + DepartureTime.GetHashCode();
        }
    }
}
