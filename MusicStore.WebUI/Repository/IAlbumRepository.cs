using MusicStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MusicStore.WebUI.Repository
{
    public interface IAlbumRepository
    {
        List<Album> FindAll();

        List<Album> BestAlbums(int numberOfAlbumsTaken);

        Album FindAlbumById(int albumId);
       
    }
}
