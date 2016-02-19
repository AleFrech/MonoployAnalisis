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

        public static void AddGo(Player player)
        {
            player.AddFunds(GO);
        }

        public static void ChargeRent(Property property, Player player)
        {
           return TransferFunds(property.Owner, player, CalculateRent(property), false);
        }


        private static int CalculateRent(Property property)
        {
            int rent = 0;
            rent += property.Cost;
            rent += property._housePrices[property.GetHousesAmount];
            rent += property.GetHasHotel ? property._hotelPrice : 0;

            return rent;
        }
    }
}
