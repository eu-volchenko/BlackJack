using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDAL.Entities
{
    class Round
    {
        public int Id { get; set; }
        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}
