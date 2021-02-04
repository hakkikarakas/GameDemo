using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
   public abstract class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted :" + gamer.Username);
        }

        public virtual void Save(Gamer gamer) 
        {
            Console.WriteLine("Save to game : "+ gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated : " + gamer.FirstName);
        }
    }
}
