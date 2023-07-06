using Ecommerce.Entities.Concred;

namespace HashEcommerce.WebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
