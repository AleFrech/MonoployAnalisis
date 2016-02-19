using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    public class IncomeTax : BoardObject
    {
        public IncomeTax() : base("Income Tax")
        {

        }

        public bool ChargeIncome(Player player)
        {
            return Bank.ReduceFunds(player, 200, true);
        }
    }
}