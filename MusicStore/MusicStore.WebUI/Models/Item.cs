using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.WebUI.Models
{
    public class Item
    {
        public Album Album { get; set; }
        public int Quantity { get; set; }
    }
}