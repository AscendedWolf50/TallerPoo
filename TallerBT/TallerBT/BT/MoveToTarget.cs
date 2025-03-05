using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class MoveToTarget : TaskNode
    {
        private Agente agent;
        private int target;
        private int step;

        public MoveToTarget(Agente agent, int targetPos, int stepSize)
        {
            this.agent = agent;
            target = targetPos;
            step = stepSize;
        }

        public override bool Execute()
        {
            if (agent.Position >= target)
            {
                Console.WriteLine($"¡Objetivo alcanzado en {target}!");
                return true;
            }

            agent.Move(step);
            return false;
        }
    }
}
