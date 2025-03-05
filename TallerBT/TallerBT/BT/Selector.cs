using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class Selector : Node
    {
        private Agente agent;
        private int distanciaValida;
        private int objetivo;

        public Selector(Agente agent, int distanciaValida, int objetivo)
        {
            this.agent = agent;
            this.distanciaValida = distanciaValida;
            this.objetivo = objetivo;
        }

        public override bool Execute()
        {
            if (agent.DistanciaAlObjetivo(objetivo) <= distanciaValida)
            {
                Console.WriteLine("El objetivo está dentro de la distancia válida.");
                return true;
            }

            foreach (Node child in children)
            {
                if (child.Execute()) return true;
            }
            return false;
        }
    }
}
