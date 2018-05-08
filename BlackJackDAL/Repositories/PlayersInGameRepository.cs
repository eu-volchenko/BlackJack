using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackDAL.EF;
using BlackJackDAL.Entities;

namespace BlackJackDAL.Repositories
{
    class PlayersInGameRepository:EFGenericRepository<PlayersInGame>
    {
        public PlayersInGameRepository(DbContext context) : base(context)
        {
        }
    }
}
