using System.Collections.Generic;
using BasketCase.Domain.Basket;

namespace BasketCase.Domain.Discounts
{
    public interface IBasketDiscountCalculator
    {
        double GetDiscountForBasketItems(IList<BasketItem> items);
    }
}