using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entity;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        void Sales(Gamer gamer, Game game, Campaign campaign);
        List<Order> getAllOrders();
    }
}
