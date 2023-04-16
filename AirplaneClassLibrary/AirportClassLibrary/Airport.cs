using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneClassLibrary;

namespace AirportClassLibrary
{
    public class Airport
    {
        private List<Airplane> _airplanes;
        
        public Airport()
        {
            _airplanes = new List<Airplane>();
        }

        public void AddingAirplane(Airplane airplane)
        {
            _airplanes.Add(airplane);

            _airplanes = _airplanes.OrderBy(x => x.DepartureTime).ToList();
        }

        public Airplane GettingAirplaneInfoFromIndex(int index)
        {
            if (!(index > _airplanes.Count || index < 0))
            {
                return _airplanes[index];
            }
            else
            {
                return null;
            }
        }

        public List<Airplane> GettingAirplanesFromThisHour(DateTime time)
        {
            DateTime timeFromHour = new DateTime(time.Year, time.Month, time.Day, time.Hour + 1,
                                                time.Minute, time.Second, DateTimeKind.Local);

            List<Airplane> airplanesFromThisHour = new List<Airplane>();

            for (int i = 0; i < _airplanes.Count; i++)
            {
                if (_airplanes[i].DepartureTime > time && _airplanes[i].DepartureTime < timeFromHour)
                {
                    airplanesFromThisHour.Add(_airplanes[i]);
                }
            }

            return airplanesFromThisHour;
        }

        public List<Airplane> GettingAiplanesGoingToPointName(string destinationName)
        {
            List<Airplane> airplanesGoingToPointName = new List<Airplane>();

            for (int i = 0; i < _airplanes.Count; i++)
            {
                if (_airplanes[i].DestinationName == destinationName)
                {
                    airplanesGoingToPointName.Add(_airplanes[i]);
                }
            }

            return airplanesGoingToPointName;
        }

        public List<Airplane> GettingAirplaneList()
        {
            return _airplanes;
        }
    }
}
