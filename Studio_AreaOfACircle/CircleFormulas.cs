using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_AreaOfACircle
{
    class CircleFormulas
    {
        public static double CircleArea(double input)
        {
            double circleArea = Math.PI * Math.Pow(input, 2);
            return circleArea;
        }

        public static double CircleCircumference(double input)
        {
            double circleCircumference = 2 * Math.PI * input;
            return circleCircumference;
        }

        public static double CircleDiameter(double input)
        {
            double circleDiameter = 2 * input;
            return circleDiameter;
        }






    }
}
