using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO.BT
{
    public abstract class Composite : Node
    {
        protected List<Node> children = new List<Node>(); // Lista de hijos

        public void AddChild(Node node)
        {
            children.Add(node);
        }
    }
}
