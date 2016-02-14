using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using BasketCase.Domain.Basket;

namespace BasketCase.Domain.Calculators
{
    public interface IBasketCalculator
    {
        double GetItemPrice(BasketItemType itemType);
        double GetDiscountForBasketItems(IList<BasketItem> items);
        double GetRawTotalForItems(IList<BasketItem> items);
    }
}