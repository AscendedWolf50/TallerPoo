using System;
using TallerBT.BT;

class Program
{
    static void Main()
    {
        
        Agente agent = new Agente(0);

        // Crear nodos del árbol
        Selector selector = new Selector();
        MoveToTarget moveTask = new MoveToTarget(agent, 10, 2);
        WaitTask waitTask = new WaitTask(1000);

       
        selector.AddChild(moveTask);
        selector.AddChild(waitTask);

        
        Root root = new Root(selector);

        
        Console.WriteLine("Iniciando... \n");
        while (!moveTask.Execute()) // ejecutar hasta que el agente llegue al objetivo
        {
            root.Execute(); // 
        }
        Console.WriteLine("\nCompletado.");
    }
}
