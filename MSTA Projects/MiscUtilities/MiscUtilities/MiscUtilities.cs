using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class MiscUtilities
    {
        public double KiloToPoundsFactor
        {
            get
            {
                return 2.20462262185;
            }
        }
        public double PoundsToKiloFactor
        {
            get
            {
                return 0.45359237;
            }
        }
        public double TemperatureFtoC(double temperature)
        {
            return ((temperature - 32) * 5) / 9;
        }
        public double TemperatureCtoF(double temperature)
        {
            return (temperature * 9) / 5 + 32;
        }
        public double KiloToPounds(double weight)
        {
            return weight * KiloToPoundsFactor;
        }
        public double PoundsToKilo(double weight)
        {
            return weight * PoundsToKiloFactor;
        }
        public double CalculateBMI(int weight, double height, bool metric)
        {
            double bmi = 0.0;
            if (metric) // working with metric units
            {
                bmi = weight / (height * height);
            }
            else // working with Imperial units
            {
                bmi = weight / (height * height) * 703;
            }
            return bmi;
        }
    }
}
