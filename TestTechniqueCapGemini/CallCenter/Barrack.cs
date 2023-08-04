using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    /// <summary>
    /// Barrack  représente la caserne de pompier, elle peu envoyer un véhicule sur un lieu toucher par un incendie.
    /// Si la ville toucher par l'incendie est présente dans sa liste de ville, Elle enverra un avion, sinon elle enverra un camion.
    /// </summary>
    public class Barrack
    {
        Truck truck1 = new Truck("Paul", "Jack", "Serge");
        Truck truck2 = new Truck("Pierre", "Robert", "Evan");
        Truck truck3 = new Truck("Victor", "Andre", "Michel");

        Bombardier bombardier = new Bombardier();

        NewVehicle newVehicle = new NewVehicle(new Truck("Paul", "Jack", "Serge"));

        List<string> town;

        public Barrack(List<string> towns)
        {
            this.town = towns;
        }

        /// <summary>
        /// Envoi un véhicule à l'endroit envoyé en paramètre
        /// </summary>
        /// <param name="place"></param>
        public void SendVehicle(string place)
        {
            bool townFound = false;
            foreach (string str in town)
            {
                if (str.Equals(place))
                {
                    bombardier.Extinguish();
                    townFound = true;
                }
            }
            if (!townFound)
            {
                truck1.Extinguish();
            }
            Console.WriteLine("Le feu à " + place + " c'est éteint\n");
        }

        public void SendNewVehicle(string place)
        {
            newVehicle.Extinguish();
        }
    }
}
