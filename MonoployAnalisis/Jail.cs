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
            _playerInJail.Remove(player);
            _turnsInJail.RemoveAt(_playerInJail.IndexOf(player));
        }


        public bool AttemptingToJail(int dice1, int dice2, Player player)
        {
            if (dice1 == dice2)
            {
                LeaveJail(player);
                return true;
            }

            if (_turnsInJail[_playerInJail.IndexOf(player)] != 0)
            {

                _turnsInJail[_playerInJail.IndexOf(player)]--;
                return false;
            }

            MessageBox.Show(player.Name + @" you have reached the max limit of turns a 50$ fee has been a credit to your bank account", @"Important Message");
            //penalty of -50$ should be applied
            LeaveJail(player);
            return true;
        }
    }
}
