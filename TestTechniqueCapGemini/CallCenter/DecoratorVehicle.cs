using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    /// <summary>
    /// Pattern Decorator. Va permettre de rajouter de nouvelles méthodes d'intervention sans toucher les méthodes existantes.
    /// </summary>
    public abstract class DecoratorVehicle : Vehicle
    {
        protected Vehicle vehicleToDecorate;

        public DecoratorVehicle(Vehicle vehicleToDecorate)
        {
            this.vehicleToDecorate = vehicleToDecorate;
        }

        public override void Extinguish()
        {
            vehicleToDecorate.Extinguish();
        }
    }
}
