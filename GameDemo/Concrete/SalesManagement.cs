using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class SalesManagement : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Username+ " adlı kullanıcı " + game.Name + " adlı oyunu aldı.");
        }
    }
}
