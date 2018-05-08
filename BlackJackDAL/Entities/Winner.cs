using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDAL.Entities
{
    class Winner
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int WinningsAmount { get; set; }

        public Player Player { get; set; }
    }
}
