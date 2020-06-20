using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.WebUI.Repository;
namespace MusicStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        
        private IAlbumRepository albumRepository = new AlbumRepository();
        public int numberOfAlbumsTaken = 6;
        public ActionResult Genre()
        {
            ViewBag.Name = "Best Albums";
            ViewBag.Genre = null; 
            ViewBag.Albums = albumRepository.BestAlbums(numberOfAlbumsTaken);
            return View();
        }
    }
}