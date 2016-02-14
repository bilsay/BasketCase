using System.Collections.Generic;
using System.Linq;
using BasketCase.Domain.Basket;
using BasketCase.Domain.Discounts;
using BasketCase.Domain.Prices;

namespace BasketCase.Domain.Calculators
{
    //Seperated this responsibility of price calculation for the basket.
    public class DTBasketCalculator : IBasketCalculator
    {
        //A better way is to inject the discount calculator
        private DTBasketDiscountCalculator _basketDiscountCalculator;
        private DTBasketItemPriceDirectory _priceDirectory;

        public DTBasketCalculator()
        {
            _priceDirectory = new DTBasketItemPriceDirectory();
            _basketDiscountCalculator = new DTBasketDiscountCalculator(_priceDirectory);
        }

        public double GetItemPrice(BasketItemType itemType)
        {
            return _priceDirectory.Get(itemType);
        }

        public double GetDiscountForBasketItems(IList<BasketItem> items)
        {
            return _basketDiscountCalculator.GetDiscountForBasketItems(items);
        }

        public double GetRawTotalForItems(IList<BasketItem> items)
        {
            return items.Sum(basketItem => basketItem.Price);
        }
    }
}