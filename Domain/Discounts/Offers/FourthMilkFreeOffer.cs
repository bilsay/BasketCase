using System.Collections.Generic;
using BasketCase.Domain.Basket;
using BasketCase.Util;
using System.Linq;

namespace BasketCase.Domain.Discounts.Offers
{
    public class FourthMilkFreeOffer : Offer
    {
        public override double GetDiscountAmount(IList<BasketItem> items)
        {  
            //If there is no bread, do not fuss
            if (items.All(i => i.ItemType != BasketItemType.Milk))
            {
                return 0.0;
            }

            return items.First(i => i.ItemType == BasketItemType.Milk).Price;
        }

        public override int GetNumberOfApplicationsToItems(IList<BasketItem> items)
        {
            int numberOfMilks = items.Count(i => i.ItemType == BasketItemType.Milk);

            return numberOfMilks / 3;
        }
    }
}
