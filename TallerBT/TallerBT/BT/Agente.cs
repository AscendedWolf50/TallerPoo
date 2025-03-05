using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{

    public class Agente
    {
        public int Posicion { get; private set; }  // Se cambia "Position" por "Posicion"

        public Agente(int posicionInicial)
        {
            Posicion = posicionInicial;
        }

        public int DistanciaAlObjetivo(int objetivo)
        {
            return Math.Abs(objetivo - Posicion);
        }

        public void MoverHaciaObjetivo(int objetivo)
        {
            if (Posicion < objetivo)
                Posicion++;
            else if (Posicion > objetivo)
                Posicion--;

            Console.WriteLine($"Agente se movió a la posición: {Posicion}");
        }
    }
}
