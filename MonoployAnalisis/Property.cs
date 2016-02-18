using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    class Property
    {
        private int _cost;
        public Player Owner;

        public int Cost
        {
            get { return _cost; }
        }

        public Property(int cost)
        {
            _owner = null;
            _cost = cost;
        }
    }
}
