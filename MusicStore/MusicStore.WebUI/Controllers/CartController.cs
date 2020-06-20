using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.WebUI.Repository;
using MusicStore.WebUI.Models;

namespace MusicStore.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IAlbumRepository ialbumRepository = new AlbumRepository();
        private IOrderRepository iorderRepository = new OrderRepository();
        private IOrderDetailsRepository iorderDetailsRepository = new OrderDetailsRepository();

        public ActionResult Cart()
        {
            return View("Cart");
        }

       
        // GET: Cart
        public ActionResult Buy(int idAlbum)
        {
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item()
                {
                    Album = ialbumRepository.FindAlbumById(idAlbum),
                    Quantity = 1
                });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = IfExist(idAlbum);
                if (index == (-1))
                {
                    cart.Add(new Item()
                    {
                        Album = ialbumRepository.FindAlbumById(idAlbum),
                        Quantity = 1
                    });
                }

                else
                {
                    cart[index].Quantity = cart[index].Quantity + 1;
                }


                Session["cart"] = cart;
            }
            return View("Cart");
        }

        public ActionResult Delete(int idAlbum)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int indexOfAlbumToRemove = IfExist(idAlbum);
            cart.RemoveAt(indexOfAlbumToRemove);
            Session["cart"] = cart;
            return View("Cart");
        }

       


        /// <summary>
        /// per te kuptuar nese ekziston ky item ne liste ose jo
        /// </summary>
        /// <param name="idAlbum"></param>
        /// <returns></returns>
        private int IfExist(int idAlbum)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int index = 0; index < cart.Count();index++)
            {
                if (cart[index].Album.AlbumID == idAlbum)
                    return index;
                
                    
            }
            return -1;
        }

        public ActionResult CheckoutAndShipping()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("MyAccount", "Account");
            }
            else
            {
                return View(new ShippingDetails());
            }
        }

        [HttpPost]
        public ActionResult CheckoutAndShipping(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                return View("Checkout");
            }
            else
            {
                return View(shippingDetails);
            }
        }




        public ActionResult Checkout()
        {
            
                List<Item> cart = (List<Item>)Session["cart"];
                //save order
                Order order = new Order();
                var creationDate = DateTime.Now;
                order.Name = "NewOrder" + creationDate.ToString();
                order.UserID = (int)Session["userID"];
                int orderID = iorderRepository.CreateOrder(order);

                //save orderdetails
                foreach (var item in cart) {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderID = orderID;
                    orderDetail.AlbumID = item.Album.AlbumID;
                    orderDetail.Quantity = item.Quantity;
                    iorderDetailsRepository.CreateOrderDetail(orderDetail);
                 }
                //remove cart
                Session.Remove("cart");



                return View("ThanksForBuying");
            
        }


    }
}