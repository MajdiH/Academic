using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AtelierLib;

namespace Aterlier
{
    public abstract class PointSystem
    {
        
       
        public abstract ITotal initialPoints
        {
            get;
        }
        public ITotal GetPointsFromMatch(Match m, bool isHome)
        {
            return null;
        }
        public interface ITotal
        {
            void Increment(ITotal with);
            String ToString();
        }
    }
}
