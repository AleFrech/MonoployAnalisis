using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    public class Go:BoardObject
    {
        public Go() : base("Go")
        {
            
        }


        public void AddGo(Player player)
        {
            Bank.AddGo(player);
        }
    }
}
