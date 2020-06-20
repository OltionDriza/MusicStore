using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.WebUI.Repository;

namespace MusicStore.WebUI.Controllers
{
    public class AlbumsController : Controller
    {
        private IGenreRepository genreRepository = new GenreRepository();
        private IAlbumRepository albumRepository  = new AlbumRepository();
        // GET: Products
       

        /// <summary>
        /// Shfaq produktet sipas kategorive
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Genre(int id)
        {
            var genre = genreRepository.FindGenreById(id);
            ViewBag.Genre = genre;
            ViewBag.Name=genre.Name;
            ViewBag.Albums = genreRepository.FindGenreById(id).Albums.ToList();
            return View();
        }

        public ActionResult AlbumDetails(int id)
        {
            ViewBag.Album = albumRepository.FindAlbumById(id);
            return View();
        }


    }
}