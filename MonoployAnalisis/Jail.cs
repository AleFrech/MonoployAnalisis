using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoployAnalisis
{
    class Jail
    {
        private List<Player> _playerInJail;
        private List<int> _turnsInJail;

        public Jail()
        {
            _playerInJail = new List<Player>();
            _turnsInJail = new List<int>();
        }


        public bool playerIsInJail(Player player)
        {
            foreach (var p in _playerInJail)
            {
                if (p == player)
                    return true;
            }
            return false;
        }

        public void goToJail(Player player)
        {
            _playerInJail.Add(player);
            _turnsInJail.Add(3);

        }

        public void leaveJail(Player player)
        {
            _playerInJail.Remove(player);
            _turnsInJail.RemoveAt(_playerInJail.IndexOf(player));
        }


        public bool attemptingToJail(int dice1, int dice2, Player player)
        {
            if (dice1 == dice2)
            {
                leaveJail(player);
                return true;
            }

            if (_turnsInJail[_playerInJail.IndexOf(player)] != 0)
            {

                _turnsInJail[_playerInJail.IndexOf(player)]--;
                return false;
            }

            MessageBox.Show(player.Name + @" you have reached the max limit of turns a 50$ fee has been a credit to your bank account", @"Important Message");
            //penalty of -50$ should be applied
            leaveJail(player);
            return true;
        }
    }
}
