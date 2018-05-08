using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDAL.Entities
{
    class Game
    {
        public int Id { get; set; }
        public int DealerId { get; set; }

        public Dealer Dealer { get; set; }
    }
}
