using System;
using System.Collections.Generic;
using BasketCase.Domain.Calculators;

namespace BasketCase.Domain.Basket
{
    public class Basket
    {
        private List<BasketItem> _items;
        private IBasketCalculator _basketCalculator;

        //Dream of a world when this is injected via StructureMap
        public Basket(IBasketCalculator basketCalculator)
        {
            _items = new List<BasketItem>();
            _basketCalculator = basketCalculator;
        }

        public double Total
        {
            get
            {
                return Math.Round(TotalRaw - Discount, 2);
            }
        }

        public double TotalRaw
        {
            get
            {
                return Math.Round(_basketCalculator.GetRawTotalForItems(_items), 2);
            }
        }

        public double Discount
        {
            get
            {
                return Math.Round(_basketCalculator.GetDiscountForBasketItems(_items), 2);
            }
        }

        public void Clear()
        {
            _items.Clear();
        }

        public void Add (BasketItem basketItem)
        {
            basketItem.Price = _basketCalculator.GetItemPrice(basketItem.ItemType);

            _items.Add(basketItem);
        }
    }
}