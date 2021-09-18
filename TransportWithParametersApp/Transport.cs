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
            int sum;

            if(transportInKm < 5 && weight < 10)
            {
                sum = 0;
            }
            else if(transportInKm < 5 && weight >= 10)
            {
                sum = 50;
            }
            else if(transportInKm >= 5 && weight < 10)
            {
                sum = 75;
            }
            else
            {
                sum = 100;
            }

            return sum;
        }
    }
}
