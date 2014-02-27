using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierLib
{
   
    public class Match
    {
        Club home;
        Club away;
        int hgoals;
        int agoals;
        bool _isHomeForfait;
        bool _isAwayForfait;
        

        public Match(Club _home, Club _away, bool _isHomeForfait, bool _isAwayForfait) //Forfait
        {
            this.home = _home;
            this.away = _away;
            this._isHomeForfait = _isHomeForfait;
            this._isAwayForfait = _isAwayForfait;
          
        }
        
        public Match(Club _home, Club _away, int _hgoals, int _agoals)
        {
            this.home = _home;
            this.away = _away;
            this.hgoals = _hgoals;
            this.agoals = _agoals;
        }

        public Club Away
        {
            get
            {
                return this.away;
            }
        }

        public int AwayGoals
        {
            get
            {
                return this.agoals;
            }
        }


        public Club Home
        {
            get
            {
                return this.home;
            }
        }

        public int HomeGoals
        {
            get
            {
                return this.hgoals;
            }
        }

        public bool isAwayForfait
        {
            
                get
                {
                    return this._isAwayForfait;
                }
            
        }

        public bool isDraw
        {
            get
            {
                if (this.hgoals == this.agoals) return true; else return false;
            }
        }

        public bool isHomeForfait
        {
            get
            {
                return this._isHomeForfait;
            }
        }

        
    }
    
}
