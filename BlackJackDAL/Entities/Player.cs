using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDAL.Entities
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AllMoney { get; set; }
        public int Rate { get; set; }
    }
}
