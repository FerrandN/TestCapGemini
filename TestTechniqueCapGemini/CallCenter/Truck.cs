using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    public class Truck : Vehicle
    {
        FireFighter firefighter1;
        FireFighter firefighter2;
        FireFighter firefighter3;

        List<FireFighter> firefighters = new List<FireFighter>();
        /// <summary>
        /// Le camion est composé de 3 pompiers qui ont chacun un nom
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        /// <param name="name3"></param>
        public Truck(string name1, string name2, string name3)
        {
            this.firefighter1 = new FireFighter(name1);
            this.firefighter2 = new FireFighter(name2);
            this.firefighter3 = new FireFighter(name3);
            addFireFighterToList();
        }

        public List<FireFighter> Firefighters { get { return firefighters; } }

        /// <summary>
        /// Les pompier éteigne le feu.
        /// </summary>
        public override void Extinguish()
        {
            int passage = 0;
            do
            {
                Console.WriteLine("Les pompiers essaie d'éteindre le feu\n");
                foreach (FireFighter fighter in Firefighters)
                {
                    Console.WriteLine(fighter.Name + " Jette de l'eau sur le feu");
                    passage++;
                }
            } while (passage < 15);
        }

        /// <summary>
        /// Ajoute les pompiers aux camions.
        /// </summary>
        private void addFireFighterToList()
        {
            firefighters.Add(firefighter1);
            firefighters.Add(firefighter2);
            firefighters.Add(firefighter3);
        }
    }
}
