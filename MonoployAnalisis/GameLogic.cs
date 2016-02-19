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
    }
}
