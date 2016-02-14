using System.Collections.Generic;
using System.Linq;
using BasketCase.Domain.Basket;
using BasketCase.Util;

namespace BasketCase.Domain.Discounts.Offers
{
    public interface IOffer
    {
        int GetNumberOfApplicationsToItems(IList<BasketItem> items);
        double GetDiscountForItems(IList<BasketItem> items);
        double GetDiscountAmount(IList<BasketItem> items);
    }

    public abstract class Offer : IOffer
    {
        public double GetDiscountForItems (IList<BasketItem> items)
        {
            return GetNumberOfApplicationsToItems(items) * GetDiscountAmount(items);
        }

        public abstract double GetDiscountAmount(IList<BasketItem> items);
        public abstract int GetNumberOfApplicationsToItems(IList<BasketItem> items);
    }
}