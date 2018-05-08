using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.DTO
{
    class CardsFromPlayersDTO
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public int RoundId { get; set; }
    }
}
