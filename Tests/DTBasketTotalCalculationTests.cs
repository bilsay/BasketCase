using System.Runtime;
using BasketCase.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasketCase.Tests
{
    [TestClass]
    public class DTBasketTotalCalculationTests : BasketBase
    {
        public void One_Bread_One_Butter_One_Milk_IsAdded()
        {
            Basket.Add(new BasketItem(BasketItemType.Milk));
            Basket.Add(new BasketItem(BasketItemType.Butter));
            Basket.Add(new BasketItem(BasketItemType.Bread));
        }

        public void Two_Butters_Two_Breads_AreAdded()
        {
            Basket.Add(new BasketItem(BasketItemType.Milk));
            Basket.Add(new BasketItem(BasketItemType.Butter));
            Basket.Add(new BasketItem(BasketItemType.Bread));
        }

        public void Four_Milks_Are_Added ()
        {
            Basket.Add(new BasketItem(BasketItemType.Milk));
            Basket.Add(new BasketItem(BasketItemType.Butter));
            Basket.Add(new BasketItem(BasketItemType.Bread));
        }

        public void Two_Butters_One_Bread_And_8_Milks_Are_Added()
        {
            Basket.Add(new BasketItem(BasketItemType.Milk));
            Basket.Add(new BasketItem(BasketItemType.Butter));
            Basket.Add(new BasketItem(BasketItemType.Bread));
        }

        [TestMethod]
        public void Then_Discount_Should_Not_Be_Applied ()
        {
            Basket.Clear();
            When(One_Bread_One_Butter_One_Milk_IsAdded);
            Assert.AreEqual(2.95, Basket.Total);
        }

        [TestMethod]
        public void Then_Discount_Should_Have_Been_Applied()
        {
            Basket.Clear();
            When(Two_Butters_Two_Breads_AreAdded);
            Assert.AreEqual(3.10, Basket.Total);

            Basket.Clear();
            When(Four_Milks_Are_Added);
            Assert.AreEqual(3.45, Basket.Total);

            Basket.Clear();
            When(Two_Butters_One_Bread_And_8_Milks_Are_Added);
            Assert.AreEqual(9.00, Basket.Total);
        }


        //public override void When()
        //{
        //    this.calc.Add(2, 4);
        //}

        //public override void When()
        //{
        //    this.calc.Add(2, 4);
        //}

        //[TestMethod]
        //public void ThenItShouldDisplay6()
        //{
        //    Assert.AreEqual(6, this.calc.Result);
        //}

        //[TestMethod]
        //public void ThenTheCalculatorShouldNotBeNull()
        //{
        //    Assert.IsNotNull(this.calc);
        //}
    }
}