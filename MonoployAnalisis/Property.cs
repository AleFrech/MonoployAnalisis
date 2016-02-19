using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoployAnalisis
{
    public enum Colors

{
    Purple,Darkblue,Lightgreen,Lightyellow,
    Orange,Darkyellow,Pink,Lightblue
}

    public class Property: BoardObject
    {
        public readonly Colors _colors;
        public readonly double _rent;
        public readonly double[] _housePrices;
        public readonly double _hotelPrice;
        public readonly double _mortgage;
        public readonly double _houseCost;
        public readonly int _cost;
        public Player  Owner;
        private bool _hasHotel;
        private int _housesAmount;
        public Property(Colors colors, double rent, double[] housePrices, double hotelPrice, double mortgage, double houseCost, string name, int cost,Player Owner):base(name)
        {
            _colors = colors;
            _rent = rent;
            _housePrices = housePrices;
            _hotelPrice = hotelPrice;
            _mortgage = mortgage;
            _houseCost = houseCost;
            _cost = cost;
            _housesAmount = 0;
            _hasHotel = false;
            Owner = Owner;
        }

        public int GetHousesAmount()
        {
            return _housesAmount;
        }

        public int AddHouses(int amount)
        {
            if (amount < 4 && _housesAmount + amount < 4)
            {
                _housesAmount += amount;
                return _housesAmount;
            }
            return -1;
        }

        public bool GetHasHotel()
        {
            return _hasHotel;
        }

        public void SetHasHotel()
        {
            _hasHotel = !_hasHotel;
        }

    }
}
