using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class OrderManager:IOrderService
    {
        Order order;
        List<Order> orders = new List<Order>();

        public List<Order> getAllOrders()
        {
            return orders;
        }

        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            order = new Order();

            order.SiparisNo=orders.Count()+1;
            order.Description =game.Name+" adlı oyunu,"+campaign.Name+" kampanyasıyla "+gamer.FirstName+" adlı oyunucu satın aldı.";
            orders.Add(order);
            Console.WriteLine("Satış Yapıldı :"+order.Description);
        }
    }
}
