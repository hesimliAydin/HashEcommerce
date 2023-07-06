using Ecommerce.Business.Abstract;
using HashEcommerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HashEcommerce.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToAdd=_productService.GetById(productId);
            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart,productToAdd);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your product,{0} was added succesfully to cart",productToAdd.ProductName));
            return RedirectToAction("Index", "Product");
        }

        public IActionResult List()
        {
            var cart=_cartSessionService.GetCart();
            
            return View();
        }
    }
}
