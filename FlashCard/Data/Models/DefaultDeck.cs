using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Data.Models
{
    public class DefaultDeck : Deck
    {
        private string _description;
        private List<DefaultCard> _cards;

        public string Description { get { return _description; } set { _description = value; } }

        public List<DefaultCard> Cards { get { return this._cards; } set { this._cards = value; } }

        //Constructor
        public DefaultDeck()
        {
            _description = "This is a deck of cards.";
            _cards = new List<DefaultCard>();
        }

        public DefaultDeck(Deck deck)
        {
            ID = deck.ID;
            Name = deck.Name;
            _description = "This is a deck of cards.";
            _cards = deck.Cards.Cast<DefaultCard>().ToList();
        }
    }
}