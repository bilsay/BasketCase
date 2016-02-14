using System.Collections.Generic;
using BasketCase.Domain.Basket;
using BasketCase.Util;
using System.Linq;

namespace BasketCase.Domain.Discounts.Offers
{
    public class FiftyPercentOffOnBreadForTwoButtersOffer : Offer
    {
        public override double GetDiscountAmount(IList<BasketItem> items)
        {
            //If there is no bread, do not fuss
            if (items.All(i => i.ItemType != BasketItemType.Bread))
            {
                return 0.0;
            }

            //We know that there is bread here;
            double breadPrice = items.First(i => i.ItemType == BasketItemType.Bread).Price;

            return breadPrice / 2;
        }

        public override int GetNumberOfApplicationsToItems(IList<BasketItem> items)
        {
            int numberOfButters = items.Count(i => i.ItemType == BasketItemType.Butter);

            return numberOfButters / 2;
        }
    }
}
