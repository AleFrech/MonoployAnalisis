using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    class Bank
    {
        private static int _go = 200;
        private static int _startingFunds =  1500;

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

        public static bool TransferFunds(Player fromPlayer, Player toPlayer, int amount)
        {
            return TransferFunds(fromPlayer, toPlayer, amount, false);
        }

        public static void AddGo(Player player)
        {
            player.AddFunds(_GO);
        }

        public static bool ChargeRent(Property property, Player player)
        {
           return TransferFunds(property.Owner, player, CalculateRent(property), false);
        }


        private static int CalculateRent(Property property)
        {
            int rent = 0;
            rent += property._cost;
            rent += property._housePrices[property.GetHousesAmount];
            rent += property.GetHasHotel ? property._hotelPrice : 0;

            return rent;
        }

        public static void InitializeStartFunds(IList<Player> players)
        {
            foreach(var player in players)
            {
                player.AddFunds(_startingFunds);
            }
        }

        public static bool ReduceFunds(Player player, int amount, bool reThrows)
        {
            try
            {
                player.ReduceFunds(amount)
            }
            catch(InsufficientFundsException ex)
            {
                if (reThrows){ throw ex; }
                return false;
            }

            return true;
        }
    }
}
