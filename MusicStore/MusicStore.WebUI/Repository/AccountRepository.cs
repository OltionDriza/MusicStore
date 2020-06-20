using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.WebUI.Models;

namespace MusicStore.WebUI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private FinalMusicStoreEntities finalMusicStoreEntities = new FinalMusicStoreEntities();

        public void CreateAccount(Account account)
        {
            finalMusicStoreEntities.Accounts.Add(account);
            finalMusicStoreEntities.SaveChanges();
        }

        public Account Login(string username, string password)
        {
            try
            {
                return finalMusicStoreEntities.Accounts.Single(account => account.UserName.Equals(username)
                           && account.Password.Equals(password));
            }
            catch
            {
                return null;
            }
        }
    }
}