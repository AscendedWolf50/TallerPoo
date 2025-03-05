using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class WaitTask : Node
    {
        private int tiempoEspera;

        public WaitTask(int tiempoEspera)
        {
            this.tiempoEspera = tiempoEspera;
        }

        public override bool Execute()
        {
            Console.WriteLine($"Esperando {tiempoEspera / 1000} segundos...");
            Thread.Sleep(tiempoEspera);
            return true;
        }
    }
}
