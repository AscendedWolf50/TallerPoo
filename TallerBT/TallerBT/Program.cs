using System;
using TallerBT.BT;

class Program
{
    static void Main()
    {
        Agente agent = new Agente(0);
        int distanciaValida = 2;
        int objetivo = 10;
        int tiempoEspera = 1000;

        // Crear nodos del árbol
        Selector selector = new Selector(agent, distanciaValida, objetivo);
        MoveToTarget moveTask = new MoveToTarget(agent, objetivo, distanciaValida);
        WaitTask waitTask = new WaitTask(tiempoEspera);

        // Crear secuencia que contiene el selector y la espera
        Sequence sequence = new Sequence();
        sequence.AddChild(selector);
        sequence.AddChild(waitTask);

        // Raíz del árbol
        Root root = new Root(sequence);

        Console.WriteLine("Iniciando... \n");
        while (!moveTask.Execute()) // Ejecutar hasta que el agente llegue al objetivo
        {
            root.Execute();
        }
        Console.WriteLine("\nCompletado.");
    }
}
