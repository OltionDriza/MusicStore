using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.WebUI.Models;

namespace MusicStore.WebUI.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private FinalMusicStoreEntities finalMusicStoreEntities = new FinalMusicStoreEntities();

        public int CreateOrder(Order order)
        {
            this.finalMusicStoreEntities.Orders.Add(order);
            this.finalMusicStoreEntities.SaveChanges();
            return order.OrderID;
        }
    }
}