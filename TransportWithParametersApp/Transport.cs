using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportWithParametersApp
{
    public class Transport
    {
        public int TransportCalculator(int transportInKm, int weight)
        {
            // Sætter transport summen til at være 0,- kr default for km < 5 og vægt < 10
            int sum = 0;

            if(transportInKm < 5 && weight >= 10)
            {
                sum = 50;
            }
            else if(transportInKm >= 5 && weight < 10)
            {
                sum = 75;
            }
            else if(transportInKm >= 5 && weight >= 10)
            {
                sum = 100;
            }

            return sum;
        }
    }
}
