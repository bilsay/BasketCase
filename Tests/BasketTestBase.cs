using BasketCase.Domain;
using BasketCase.Domain.Basket;
using BasketCase.Domain.Calculators;

namespace BasketCase.Tests
{
    public abstract class BasketTestBase : TestBase
    {
        protected Basket Basket;

        public override void Given()
        {
            //Basket = new Basket(new DTBasketDiscountCalculator(), new DTBasketItemPriceDirectory());
            Basket = new Basket(new DTBasketCalculator());
        }
    }
}