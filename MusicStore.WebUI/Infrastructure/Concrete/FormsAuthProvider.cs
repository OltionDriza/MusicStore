using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.WebUI.Infrastructure.Abstract;
using System.Web.Security;

namespace MusicStore.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            bool result = FormsAuthentication.Authenticate(username, password);
#pragma warning restore CS0618 // Type or member is obsolete
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}