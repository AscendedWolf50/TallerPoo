using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerBT.BT
{
    public class Sequence : Composite
    {
        public override bool Execute()
        {
            foreach (Node child in children)
            {
                if (!child.Execute()) // Si un hijo falla, la secuencia falla
                    return false;
            }
            return true; // Si todos tuvieron éxito, la secuencia tiene éxito
        }
    }
}
