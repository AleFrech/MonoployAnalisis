using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    public class GameLogic
    {
        public void Initgame(List<Player>players )
        {
            Bank.InitializeStartFunds(players);


        }

        public Tuple<int, int> RollDiceValueTuple()
        {
            Random value = new Random();
            int diceValue1 = value.Next(1, 6);
            int diceValue2 = value.Next(1, 6);
            return Tuple.Create(diceValue1, diceValue2);
        }

    }
}
