using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashCard.Data.Models
{
    public abstract class Deck
    {
        private int _id;
        private string _name;
        private List<Card> _cards;

        [Key]
        public int ID { get { return _id; } set { _id = value; } }

        public string Name 
        { 
            get { return _name; } 
            set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name field cannot be null or empty.");
                _name = value;
            } 
        }

        public List<Card> Cards { get { return _cards; } set { _cards = value; } }

        //Constructor
        public Deck() 
        {
            _name = "Card Deck";
            _cards = new List<Card>();
        }

    }
}
