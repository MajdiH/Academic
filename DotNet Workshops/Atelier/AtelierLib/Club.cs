using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierLib
{
    public class Club
    {
        string name;
        public Club(String _name)
        {
            this.name = _name;
        }
        public String getName() 
        {
            return this.name;
        }
        public override string ToString()
        {
            return  this.name.ToString();
        }

    }
}
