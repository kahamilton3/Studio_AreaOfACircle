using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_AreaOfACircle
{
    class RoadTrip
    {
        public static double GasNeeded(double radius, double milesPerGallon)
        {
            double gasNeeded = CircleFormulas.CircleCircumference(radius) / milesPerGallon;
            return gasNeeded;
        }



    }
}
