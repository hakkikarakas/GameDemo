using GameDemo.Adapters;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 1, Name = "Counter-Strike: Global Offensive", Price = 70 };

            Game game2 = new Game() { Id = 2, Name = "Among Us", Price = 57 };

            Game game3 = new Game() { Id = 3, Name = "DOTA 2", Price = 45 };

            Gamer gamer1 = new Gamer() { Id = 7, BirthYear = 1992, FirstName = "Hakkı", LastName = "Karakaş", Username = "hakkikrks", NationalityId = "46204222222", CreditCardNumber = 101010101 };

           

            //Kullanıcı bilgileri yanlış olduğu için Exceptiona gidecek, doğruları girildiğinde çalışıyor.

            Campaign campaign1 = new Campaign() { GameId = 352, CampaignName = "Kış Festivali", RateOfDiscount = 13 };
            Campaign campaign2 = new Campaign() { GameId = 368, CampaignName = "Sömestır Maratonu", RateOfDiscount = 24 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);


            BaseGamerManager customerManager = new GamerManager(new MernisServiceAdapter());
            
            customerManager.Save(gamer1);
        


            Sales sales1 = new Sales() { Game = game1.Name, Gamer = gamer1.Username };

            SalesManagement salesManagement = new SalesManagement();
            salesManagement.Buy(game1, gamer1);


        }
    }
}
