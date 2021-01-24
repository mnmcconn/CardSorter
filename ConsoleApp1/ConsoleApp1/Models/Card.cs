using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Card
    {
        #region
        // Public Properties
        public Value Value { get; set; }
        public Suit Suit { get; set; }
        #endregion
        
        #region 
        //Constructors
        public Card (Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
        #endregion
    }
}
