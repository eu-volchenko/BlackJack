using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDAL.Entities
{
    class CardsFromPlayers
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public int RoundId { get; set; }

        public Cards CardDeck { get; set; }
        public Player Player { get; set; }
        public Round Round { get; set; }
    }
}
