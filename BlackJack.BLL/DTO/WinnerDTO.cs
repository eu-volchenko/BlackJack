﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.DTO
{
    class WinnerDTO
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int WinningsAmount { get; set; }
    }
}
