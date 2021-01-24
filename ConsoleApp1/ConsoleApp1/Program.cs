using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Card> cards = GetCards();

            if ((args.Length > 0) && args[0] == "D")
            {
                cards.OrderByDescending(c => c.Value.ID).OrderByDescending(c => c.Suit.ID).ToList();
            }
            else
            {
                cards.OrderBy(c => c.Value.ID).OrderBy(c => c.Suit.ID).ToList();
            }


            foreach (Card c in cards)
            {
                Debug.WriteLine($"{ c.Value.Name} of {c.Suit.Name}");
            }
        }

        static List<Card> GetCards()
        {
            List<Card> cards = new List<Card>();

            List<Suit> suits = Utility.GetData<Suit>(Properties.Settings.Default.SuitsURI);
            List<Value> values = Utility.GetData<Value>(Properties.Settings.Default.ValuesURI);

            suits.ForEach(s => values.ForEach(v => cards.Add(new Card(s, v))));

            return cards;
        }
    }
}
