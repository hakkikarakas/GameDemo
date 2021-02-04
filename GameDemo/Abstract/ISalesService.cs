using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface ISalesService
    {
        void Buy(Game game, Gamer gamer);
    }
}
