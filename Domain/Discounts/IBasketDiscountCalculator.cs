using System.Collections.Generic;

namespace BasketCase.Domain.Discounts
{
    public interface IBasketDiscountCalculator
    {
        double GetDiscountForBasketItems(List<BasketItem> items);
    }
}