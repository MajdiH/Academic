using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AtelierLib;

namespace Aterlier
{
    public class Ranking
    {

        RankingEntry[] entries;
        PointSystem system; 

        public RankingEntry EntryFormClub(Club c)
        {
            return null;
            
        }
        public Club GetClub(int index)
        {
            return null;
        }
        public PointSystem.ITotal GetPoints(Club club)
        {
            return null;   
        }
        public PointSystem.ITotal GetPoints(int index)
        {
            return null;
        }
        public Ranking(PointSystem system, Club[] clubs)
        {
            
        }
        public void Register(Match m)
        {
           
        }
        public class RankingEntry
        {
            Club club;
            PointSystem.ITotal points;
           
            public Club Club
            {
                get
                {
                    return club;
                }
            }
            public PointSystem.ITotal Points
            {
                get;
                
            }
            public int CompareTo(object obj)
            {
                return 0;
            }
            public RankingEntry(AtelierLib.Club club, PointSystem.ITotal points)
            {
             this.club = club;
             this.points = points;
            }

           
          

        }
    }
}
