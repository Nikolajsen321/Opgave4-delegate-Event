using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._5
{
    public enum Suit
    {
        Kulør,
        Rudder,
        Hjerter,
        Spar
    }
    public enum Number
    {
        Es,
        To,
        Tre,
        Fire,
        Fem,
        Seks,
        Syv,
        Otte,
        Ni,
        Ti,
        Knægt,
        Dame
    }
    public class Card
    {
        public Card(Suit suit, Number number) 
        { 
            CardSuit = suit;
            NumberSuit = number; 
        }
      

        public Suit CardSuit { get; set; }
        public Number NumberSuit { get; set; }


        public override string ToString()
        {
            return $"{CardSuit} {NumberSuit}";
        }
    }
}
