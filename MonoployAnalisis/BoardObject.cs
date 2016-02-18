using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoployAnalisis
{
    class BoardObject
    {
        private string _name;

        public BoardObject(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
