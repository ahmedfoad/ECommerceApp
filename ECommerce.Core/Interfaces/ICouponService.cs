using ECommerce.Core.Entities;

namespace ECommerce.Core.Interfaces;

public interface ICouponService
{
    Task<AppCoupon?> GetCouponFromPromoCode(string code);
}
