using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO.BT
{
    public class Selector : Composite
    {
        public override bool Execute()
        {
            foreach (Node child in children)
            {
                if (child.Execute()) // Si un hijo tiene éxito, el selector termina con éxito
                    return true;
            }
            return false; // Si ninguno tuvo éxito, el selector falla
        }
    }
}
