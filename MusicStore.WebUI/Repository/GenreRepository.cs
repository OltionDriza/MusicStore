using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.WebUI.Models;

namespace MusicStore.WebUI.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private FinalMusicStoreEntities finalMusicStoreEntities = new FinalMusicStoreEntities();

        public List<Genre> FindAll()
        {
            return finalMusicStoreEntities.Genres.ToList();
        }

        public Genre FindGenreById(int id)
        {
            return finalMusicStoreEntities.Genres.Find(id);
        }

        

    }
}