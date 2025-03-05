using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class Agente
    {
        public int Position { get; private set; }

        public Agente(int startPos)
        {
            Position = startPos;
        }

        public void Move(int step)
        {
            Position += step;
            Console.WriteLine($"Agente moviéndose... nueva posición: {Position}");
        }
    }
}
