using MusicStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicStore.WebUI.Repository
{
    public interface IGenreRepository
    {
        List<Genre> FindAll();

        Genre FindGenreById(int id);

        
    }
}
