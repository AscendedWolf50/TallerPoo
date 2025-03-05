using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class WaitTask : TaskNode
    {
        private int waitTime;

        public WaitTask(int time)
        {
            waitTime = time;
        }

        public override bool Execute()
        {
            Console.WriteLine($"Esperando {waitTime}ms...");
            Thread.Sleep(waitTime);
            return true;
        }
    }
}
