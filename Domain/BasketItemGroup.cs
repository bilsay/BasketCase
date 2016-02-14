namespace BasketCase.Domain
{
    public class BasketItemGroup
    {
        private BasketItemType _type;
        private int _amount;

        public BasketItemGroup (BasketItemType type, int amount)
        {
            _type = type;
            _amount = amount;
        }
    }
}