using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.WebUI.Models;
using MusicStore.WebUI.Repository;

namespace MusicStore.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAccountRepository iaccountRepository = new AccountRepository();
        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(Account account)
        {
            iaccountRepository.CreateAccount(account);
            return RedirectToAction("MyAccount", "Account");
        }

        [HttpGet]
        public ActionResult MyAccount()
        {
            return View("MyAccount");
        }

        [HttpPost]
        public ActionResult MyAccount(Account account)
        {
            Account thisAccount = iaccountRepository.Login(account.UserName, account.Password);
            if (thisAccount == null)
            {
                ViewBag.errorLogIn = "Account' Invalid";
                return View("MyAccount");
            }
            else
            {
                Session["userID"] = thisAccount.UserID;
                return RedirectToAction("CheckoutAndShipping", "Cart");
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("userID");
            return RedirectToAction("MyAccount" , "Account");
        }

    }
}