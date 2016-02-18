﻿using System;
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
        private IList<Property> _ownedProperties;
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
            _piece = piece;
            _funds = 500;
            _currentPosition = 0;
            _ownedProperties = new List<Property>();
        }

        public int AddFunds(int fundsToAdd)
        {
            _funds += fundsToAdd;
            return Funds;
        }

        public void TransferFunds(Player receivingPlayer, int amountToTransfer)
        {
            if(Funds < amountToTransfer)
            {
                throw new Exception("InsufficientFundsException");
            }

            _funds -= amountToTransfer;
            receivingPlayer.AddFunds(amountToTransfer);
        }

        public void PurchaseProperty(Property property)
        {
            if (Funds < property.Cost)
            {
                throw new Exception("InsufficientFundsException");
            }

            _funds -= property.Cost;
            _ownedProperties.Add(property);
            property.Owner = this;
        }
    }
}
