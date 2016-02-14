namespace BasketCase.Domain
{
    public class BasketItem
    {
        private BasketItemType _itemType;

        public BasketItem(BasketItemType itemType)
        {
            ItemType = itemType;
        }

        public BasketItemType ItemType
        {
            get { return _itemType; }
            set { _itemType = value; }
        }
    }
}