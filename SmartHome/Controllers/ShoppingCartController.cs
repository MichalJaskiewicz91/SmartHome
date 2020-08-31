using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHome.Models;
using SmartHome.ViewModels;

namespace SmartHome.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDeviceRepository deviceRepository, ShoppingCart shoppingCart)
        {
            _deviceRepository = deviceRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int deviceId)
        {
            var selectedDevice = _deviceRepository.AllDevices.FirstOrDefault(p => p.DeviceId == deviceId);

            if (selectedDevice != null)
            {
                _shoppingCart.AddToCart(selectedDevice, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int deviceId)
        {
            var selectedDevice = _deviceRepository.AllDevices.FirstOrDefault(p => p.DeviceId == deviceId);

            if (selectedDevice != null)
            {
                _shoppingCart.RemoveFromCart(selectedDevice);
            }
            return RedirectToAction("Index");
        }
    
    }
}