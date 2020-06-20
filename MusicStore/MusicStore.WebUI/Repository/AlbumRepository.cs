using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.WebUI.Models;

namespace MusicStore.WebUI.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private FinalMusicStoreEntities finalMusicStoreEntities = new FinalMusicStoreEntities();

        public List<Album> BestAlbums(int numberOfAlbumsTaken)
        {
            return finalMusicStoreEntities.Albums.Where(p => p.GoogleRate > 95).Take(numberOfAlbumsTaken).ToList();
        }

        public Album FindAlbumById(int albumId)
        {
            return finalMusicStoreEntities.Albums.Find(albumId);

        }

        public List<Album> FindAll()
        {
            return finalMusicStoreEntities.Albums.ToList();
        }
    }
}