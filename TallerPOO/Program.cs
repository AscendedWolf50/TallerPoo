using System;
using TallerPOO.BT;

class Program
{
    static void Main()
    {
        // Crear al agente en la posición 0
        Agente agent = new Agente(0);

        // Crear nodos del árbol
        Selector selector = new Selector();
        MoveToTarget moveTask = new MoveToTarget(agent, 10, 2);
        WaitTask waitTask = new WaitTask(1000);

        // Armar el árbol
        selector.AddChild(moveTask);
        selector.AddChild(waitTask);

        // Crear la raíz con el selector como hijo principal
        Root root = new Root(selector);

        // Ejecutar el árbol de comportamiento desde la raíz
        Console.WriteLine("Iniciando... \n" );
        while (!moveTask.Execute()) // Se ejecuta hasta que el agente llegue al objetivo
        {
            root.Execute(); // Llama a la raíz para ejecutar el árbol
        }
        Console.WriteLine("Completado.");
    }
}
