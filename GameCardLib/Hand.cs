using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Hand
    {
        public List<Card> Cards { get; set; }
        public int Score
        {
            get
            {
                int score = 0;
                if (Cards == null) return score;

                Cards?.ForEach(e => score += e.Value);
                return score;
            }
        }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card c)
        {
            Cards.Add(c);
        }

    }
}
