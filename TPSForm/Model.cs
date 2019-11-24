using System.Collections.Generic;

namespace TPSForm
{
    class Model
    {
        Dictionary<FuelType, double> coefFuel = new Dictionary<FuelType, double>()
        {
            { FuelType.Lignite, 10500.0 * 1000},
            { FuelType.Anthracite, 26800.0 * 1000},
            { FuelType.Coal, 20900.0 * 1000}
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns>kg</returns>
        private double GetMassOfFuel(double massOfFuelPerSecond, int seconds)
        {
            return massOfFuelPerSecond * seconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specificHeat"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public double GetEnergyFromFuel(double specificHeat, double massOfFuelPerSecond, int seconds)
        {
            return GetMassOfFuel(massOfFuelPerSecond, seconds) * specificHeat;
        }

        public double GetEnergyFromSteam(double energy, double ccd)
        {
            return energy * ccd;
        }

        public double GetEnergy(double energy, double ccd)
        {
            return energy * ccd;
        }

        public double GetResultOfModel(FuelType fuel, double massOfFuelPerSecond, int deltaTimeSeconds, double ccdSteam, double ccdTurbin)
        {
            var coef = coefFuel[fuel];

            return GetEnergy(GetEnergyFromSteam(GetEnergyFromFuel(coef, massOfFuelPerSecond, deltaTimeSeconds), ccdSteam), ccdTurbin);
        }
    }
}
