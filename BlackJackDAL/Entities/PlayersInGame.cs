using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDAL.Entities
{
    class PlayersInGame
    {
        
        public int GameId { get; set; }
        public int PlayerId { get; set; }

        public Game Game { get; set; }
        public Player Player { get; set; }
    }
}
