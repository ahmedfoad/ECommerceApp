using ECommerce.Core.Entities;

namespace ECommerce.Core.Interfaces;

public interface IPaymentService
{
    Task<ShoppingCart?> CreateOrUpdatECommerceIntent(string cartId);
    Task<string> RefundPayment(string paymentIntentId);
}
