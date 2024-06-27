using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashCard.Data.Models
{
    public abstract class Card
    {
        private int _id;
        private string _question;
        private string _answer;
        private int _delay;


        [Key]
        public int ID { get { return _id; } set { _id = value; } }

        public string Question
        {
            get { return _question; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Question field cannot be null or empty.");
                _question = value;
            }
        }

        public string Answer
        {
            get { return _answer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be null or empty.");
                _answer = value;
            }
        }

        public int Delay { 
            get { return _delay; } 
            set {
                if(value < 0 ) throw new ArgumentOutOfRangeException("Delay must be greater than zero");
                _delay = value;
            } 
        }

        //Constructor
        public Card()
        {
            _question = "This is a default question.";
            _answer = "This is a defualt answer.";
            _delay = 2;
        }

    }
}
