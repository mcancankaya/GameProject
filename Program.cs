using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gamer gamer = new Gamer();
            gamer.FirstName = "Can";
            gamer.LastName = "YMG";
            gamer.NationalityId = "12345678901";
            gamer.DateOfBirth = new DateTime(2022,1,1);
            Game game = new Game();
            game.Id = 1;
            game.Name = "Pubg";
            game.Description = "battleground";
            game.Price = 200;

            Game game1 = new Game();
            game1.Id = 2;
            game1.Name = "Pubg Mobile";
            game1.Description = "mobile battleground";
            game1.Price = 50;

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "yaz indirimi";
            campaign.Description = "yaza özel";
            campaign.Discount = 10;

            OrderManager orderManager = new OrderManager();
            orderManager.Sales(gamer,game,campaign);
            orderManager.Sales(gamer,game1,campaign);

            Console.WriteLine("-------------------------");
            foreach (var order in orderManager.getAllOrders())
            {
                Console.WriteLine("Sipariş detay : "+order.Description );
            }

        }
    }
}
