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
        private int _currentPosition;
        public PlayerPiece Piece
        {
            get { return this._piece; }
        }
        public int Funds
        {
            get { return _funds;  }
        }
        public int CurrentPosition
        {
            get { return _currentPosition; }
        }

        public Player(PlayerPiece piece)
        {
            this._piece = piece;
            this._funds = 500;
            this._currentPosition = 0;
        }

        
    }
}
