using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._5
{

   
    public class SpilleKort
    {
        private List<Card> _card = new List<Card>();
        private FilterCardDelegate _filter;
       

        public void AddCard(Suit suit,Number number)
        {
            _card.Add(new Card(suit, number));
        }

        public List<Card> FilterCardGame(FilterCardDelegate filterCardDelegate)
        {
            List<Card> filteretCard = new List<Card>();
            foreach (Card card in _card)
            {
                if (filterCardDelegate(card))
                {
                    filteretCard.Add(card); 

                }
                
            }
            return filteretCard;
        }
    }
}
