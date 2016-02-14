using System.Collections.Generic;
using System.Linq;
using BasketCase.Domain.Basket;
using BasketCase.Domain.Discounts.Offers;
using BasketCase.Domain.Prices;

namespace BasketCase.Domain.Discounts
{
    public class DTBasketDiscountCalculator : IBasketDiscountCalculator
    {
        public IList<IOffer> _offers;
        public DTBasketItemPriceDirectory _priceDirectory;

        public DTBasketDiscountCalculator(DTBasketItemPriceDirectory priceDirectory)
        {
            _priceDirectory = priceDirectory;

            _offers = new List<IOffer>()
            {
                new FiftyPercentOffOnBreadForTwoButtersOffer(),
                new FourthMilkFreeOffer()
            };

        }

        public double GetDiscountForBasketItems(IList<BasketItem> items)
        {
            return _offers.Sum(offer => offer.GetDiscountForItems(items));
        }
    }
}