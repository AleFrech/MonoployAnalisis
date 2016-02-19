using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    class Bank
    {
        private static int GO = 200;

        public static bool TransferFunds(Player fromPlayer, Player toPlayer, int amount, bool reThrows) 
        {
            try
            {
                fromPlayer.TransferFunds(toPlayer, amount);
            }
            catch (InsufficientFundsException ex)
            {
                if (reThrows) { throw ex; }
                return false;
            }

            return true;
        }
    }
}
