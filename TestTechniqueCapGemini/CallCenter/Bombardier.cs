using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    public class Bombardier : Vehicle
    {
        /// <summary>
        /// Un avion éfféctue 4 actions pour éteindre un feu. Decoller, se remplir d'eau, aller sur les lieu de l'incendie, deverser son eau.
        /// </summary>
        public override void Extinguish()
        {
            int passage = 0;
            do
            {
                decoller();
                FillWithWater();
                PlaneGetAroundPlace();
                EmptyContainer();
                Console.WriteLine("\n");
                passage++;
            } while (passage < 4);
        }

        public void decoller()
        {
            Console.WriteLine("L'avion décolle");
        }

        public void FillWithWater()
        {
            Console.WriteLine("L'avion remplit son reservoir d'eau");
        }

        public void PlaneGetAroundPlace()
        {
            Console.WriteLine("L'avion survole le lieu");
        }

        public void EmptyContainer()
        {
            Console.WriteLine("L'avion vide son reservoir sur le feu");
        }
    }
}
