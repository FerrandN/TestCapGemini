using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter
{
    /// <summary>
    /// Pattern façade pour simplifier l'utilisation de la caserne
    /// </summary>
    public class Call
    {
        Barrack barrack;
        public Call(List<string> towns)
        {
            this.barrack = new Barrack(towns);
        }

        public void CallReceived(string place)
        {
            barrack.SendVehicle(place);
        }

        public void CallForNewVehicle(string place)
        {
            barrack.SendNewVehicle(place);
        }
    }
}
