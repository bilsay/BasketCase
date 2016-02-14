using System;
using System.Collections.Generic;
using System.Linq;
using BasketCase.Domain.Discounts;
using BasketCase.Util;

namespace BasketCase.Domain
{
    /*
     * Seperated this responsibility and made the discount calculation injectable
     *As there might be a need to use a different discount schema
     */
    public class BasketTotalCalculator
    {
        private IBasketDiscountCalculator _discountCalculator;
        private Directory<BasketItemType, double> _priceDirectory;

        public BasketTotalCalculator (IBasketDiscountCalculator discountCalculator, Directory<BasketItemType, double> priceDirectory)
        {
            _discountCalculator = discountCalculator;
            _priceDirectory = priceDirectory;
        }

        public double CalculateTotalForItems(List<BasketItem> items)
        {
            throw new NotImplementedException();
            //double discount = _discountCalculator.GetDiscountForBasketItems(items);
            //double normalSum = 
            //return 
        }
    }
}