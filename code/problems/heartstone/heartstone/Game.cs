using System.Collections;
using System.Collections.Generic;
namespace Heartstone {
    public class Game {
        private readonly List<Player> players;
        // Ignore for now
        private readonly Dictionary<Player, List<Card>> History;

        public void InitGame() {
            // TODO: initalize game state
        }
        
        public IEnumerable<Player> GetPlayers() {
            return players;
        }

        public IEnumerable<Card> GetPlayerHistory(Player player) {
            return History[player];
        }
    }
}