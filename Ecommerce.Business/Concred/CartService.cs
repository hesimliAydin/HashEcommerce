using Ecommerce.Business.Abstract;
using Ecommerce.Entities.Concred;
using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Concred
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if(cartLine == null )
            {
                cartLine.Quantity++;
            }
            else
            {
                cart.CartLines.Add(new CartLine { Quantity=1,Product= product });   
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, Product product)
        {
            cart.CartLines.Remove(cart
                .CartLines
                .FirstOrDefault(c=>c.Product.ProductId==product.ProductId));
        }
    }
}
