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
    class CardsFromPlayerRepository:EFGenericRepository<CardsFromPlayers>
    {
        public CardsFromPlayerRepository(DbContext context) : base(context)
        {
        }

    }
}
