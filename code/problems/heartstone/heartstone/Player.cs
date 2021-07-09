using System.Collections;
using System.Collections.Generic;

namespace Heartstone {
    public class Player {
        public int Mana {get; set;}
        public Deck Deck {get; private set;}
        public Hero Hero {get; private set;}
        private readonly List<Card> _hand;
        private readonly List<CreatureCard> _creatures;

        public Player() {
            _hand = new List<Card>();
            _creatures = new List<CreatureCard>();
        }

        public void StartTurn() {
        }

        public IEnumerable<Card> GetHand() {
            return _hand;
        }
    }
}
