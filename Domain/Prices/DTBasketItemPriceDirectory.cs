using BasketCase.Domain.Basket;
using BasketCase.Util;

namespace BasketCase.Domain.Prices
{
    public class DTBasketItemPriceDirectory : Directory<BasketItemType, double>
    {
        protected override void IntializeEntries()
        {
            Add(BasketItemType.Butter, 0.80);
            Add(BasketItemType.Milk, 1.15);
            Add(BasketItemType.Bread, 1.00);
        }
    }
}
