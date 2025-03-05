using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class MoveToTarget : Node
    {
        private Agente agent;
        private int objetivo;
        private int distanciaValida;

        public MoveToTarget(Agente agent, int objetivo, int distanciaValida)
        {
            this.agent = agent;
            this.objetivo = objetivo;
            this.distanciaValida = distanciaValida;
        }

        public override bool Execute()
        {
            if (agent.DistanciaAlObjetivo(objetivo) > distanciaValida)
            {
                agent.MoverHaciaObjetivo(objetivo);
                return false;  // Todavía no ha llegado al objetivo
            }

            Console.WriteLine("El agente ha alcanzado la distancia válida.");
            return true;  // Objetivo alcanzado
        }
    }
}
