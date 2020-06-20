using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.WebUI.Models;

namespace MusicStore.WebUI.Repository
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private FinalMusicStoreEntities finalMusicStoreEntities = new FinalMusicStoreEntities();

        public void CreateOrderDetail(OrderDetail orderDetail)
        {
            this.finalMusicStoreEntities.OrderDetails.Add(orderDetail);
            this.finalMusicStoreEntities.SaveChanges();
        }
    }
}