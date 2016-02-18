using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    class Player
    {
        public enum PlayerPiece
        {
            CAR,
            DOG,
            MONEY_BAG,
            WHEEL_CART
        };

        private PlayerPiece _piece;
        private int _funds;
        public PlayerPiece Piece
        {
            get { return this._piece; }
        }
        public int Funds
        {
            get { return _funds;  }
        }
        public int CurrentPosition;

        public Player(PlayerPiece piece)
        {
            this._piece = piece;
        }
    }
}
