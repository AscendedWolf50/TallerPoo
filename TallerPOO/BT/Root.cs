using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO.BT
{
    public class Root : Node
    {
        private Node child; // El único hijo del nodo raíz

        public Root(Node rootChild)
        {
            child = rootChild;
        }

        public override bool Execute()
        {
            return child.Execute(); // Llama a su único hijo
        }
    }
}
