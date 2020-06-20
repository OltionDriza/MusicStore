using MusicStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MusicStore.WebUI.Repository
{
    public interface IAccountRepository
    {
        void CreateAccount(Account account);

        Account Login(string username, string password);
       
    }
}
