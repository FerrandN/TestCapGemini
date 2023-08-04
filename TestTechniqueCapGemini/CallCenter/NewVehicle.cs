using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    public class NewVehicle : DecoratorVehicle
    {
        public NewVehicle(Vehicle vehicleToDecorate) : base(vehicleToDecorate)
        {

        }

        public override void Extinguish()
        {
            Console.WriteLine("Les pompiers sécurise les civils avant d'éteindre le feu");
            base.Extinguish();
        }
    }
}
