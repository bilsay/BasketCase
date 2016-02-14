using System.Collections.Generic;
using BasketCase.Domain.Discounts;
using BasketCase.Domain.Prices;

namespace BasketCase.Domain
{
    public class Basket
    {
        private List<BasketItem> _items;
        private BasketTotalCalculator _basketTotalCalculator;

        public Basket()
        {
            _items = new List<BasketItem>();

            /*
             * Properly inject this as cool people do
             * Normally would have setup StructureMap!
             */
            _basketTotalCalculator = new BasketTotalCalculator(new DTBasketDiscountCalculator(), new DTBasketItemPriceDirectory());
        }

        /*
         * Not gonna over-engineer now but if the total at every item addition is needed 
         * maybe consider to do this operation at add?
         */
        public double Total { get { return _basketTotalCalculator.CalculateTotalForItems(_items); } }

        public void Clear()
        {
            _items.Clear();
        }

        public void Add(BasketItem basketItem)
        {
            _items.Add(basketItem);
        }
    }
}