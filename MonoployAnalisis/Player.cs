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
        public PlayerPiece Piece
        {
            get { return this._piece; }
        }

        public Player(PlayerPiece piece)
        {
            this._piece = piece;
        }

    }
}
