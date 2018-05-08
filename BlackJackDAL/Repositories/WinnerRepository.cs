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
    class WinnerRepository:EFGenericRepository<Winner>
    {
        public WinnerRepository(DbContext context) : base(context)
        {
        }
    }
}
