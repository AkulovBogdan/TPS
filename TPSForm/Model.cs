using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSForm
{
    enum FuelType
    {
        Lignite,
        Anthracite,
        Coal
    }
    class Model
    {
        public const double MassOfFuelPerSecond = 1;

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
        private double GetMassOfFuel(int seconds)
        {
            return MassOfFuelPerSecond * seconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specificHeat"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public double GetEnergyFromFuel(double specificHeat, int seconds)
        {
            return GetMassOfFuel(seconds) * specificHeat;
        }

        public double GetEnergyFromSteam(double energy, double ccd)
        {
            return energy * ccd;
        }

        public double GetEnergy(double energy, double ccd)
        {
            return energy * ccd;
        }

        public double GetResultOfModel(FuelType fuel, int deltaTimeSeconds, double ccdTurbin, double ccdSteam)
        {
            double coef;
            coefFuel.TryGetValue(fuel, out coef);

            return GetEnergy(GetEnergyFromSteam(GetEnergyFromFuel(coef, deltaTimeSeconds),ccdSteam),ccdTurbin);
        }
    }
}
