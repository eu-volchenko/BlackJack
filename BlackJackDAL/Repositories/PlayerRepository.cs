using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackDAL.EF;
using BlackJackDAL.Entities;

namespace BlackJackDAL.Interfaces
{
    class PlayerRepository:EFGenericRepository<Player>
    {
        public PlayerRepository(DbContext context) : base(context)
        {
        }
    }
}
