using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoployAnalisis
{
    class Jail : BoardObject
    {
        private List<Player> _playerInJail;
        private List<int> _turnsInJail;

        public Jail():base("Go to jail")
        {
            _playerInJail = new List<Player>();
            _turnsInJail = new List<int>();
        }


        public bool PlayerIsInJail(Player player)
        {
            foreach (var p in _playerInJail)
            {
                if (p == player)
                    return true;
            }
            return false;
        }

        public void GoToJail(Player player)
        {
            _playerInJail.Add(player);
            _turnsInJail.Add(3);

        }

        public void LeaveJail(Player player)
        {
            _turnsInJail.RemoveAt(_playerInJail.IndexOf(player));
            _playerInJail.Remove(player);
        }


        public bool AttemptingToJail(int dice1, int dice2, Player player)
        {
            if (_turnsInJail[_playerInJail.IndexOf(player)] == 0)
            {
                var result = Bank.ReduceFunds(player, 50,true);
                if(result)
                {
                    LeaveJail(player);
                    return true;
                }
            } else if (dice1 == dice2)
            {
                LeaveJail(player);
                return true;
            }

            _turnsInJail[_playerInJail.IndexOf(player)]--;
            return false;
        }
    }
}
