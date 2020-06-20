using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MusicStore.WebUI.Models;


namespace MusicStore.WebUI.Models
{
    public class AlbumListViewModel
    { 
        public IEnumerable<Album> Albums { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int CurrentGenre { get; set; }
    }
}