using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Deck
    {
        private readonly Random _rnd;
        public int Multiplier { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(int multiplier)
        {
            if (multiplier < 0) throw new ArgumentException(nameof(multiplier));
            _rnd = new Random();
            Multiplier = multiplier;
            FillDeck(multiplier);
            ShuffleDeck();
        }

        public void FillDeck(int multiplier)
        {
            Cards = new List<Card>();
            for (int i = 0; i < multiplier; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Cards.Add(new Card(j, Suite.Club, true));
                    Cards.Add(new Card(j, Suite.Diamond, true));
                    Cards.Add(new Card(j, Suite.Heart, true));
                    Cards.Add(new Card(j, Suite.Spade, true));
                }
            }
        }

        public void ShuffleDeck()
        {
            Cards = Cards.OrderBy(c => _rnd.Next()).ToList();
        }

        public void AddUsedCardsandShuffle(List<Card> usedCards)
        {
            Cards.AddRange(usedCards);
            ShuffleDeck();
        }

        public Card Pop()
        {
            if (Cards != null && Cards.Count > 0)
            {
                Card c = Cards[0];
                Cards.RemoveAt(0);
                return c;
            }
            return null;
        }

        public bool LessThanQuarterLeft()
        {
            return (52 * Multiplier) / 4 > Cards.Count;
        }
    }
}
