using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    public class SuperTax : BoardObject
    {
        public SuperTax() : base("Luxury Tax")
        {

        }

        public bool ChargeSuper(Player player)
        {
            return Bank.ReduceFunds(player, 100,true);
        }
    }
}
