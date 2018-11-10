namespace GildedRose.Console
{
    public class ConcertPassItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            InventoryManager.IncreaseQualityIfLowerThanFifty(this);

            if (SellIn < 11)
            {
                InventoryManager.IncreaseQualityIfLowerThanFifty(this);
            }

            if (SellIn < 6)
            {
                InventoryManager.IncreaseQualityIfLowerThanFifty(this);
            }

            InventoryManager.DecreaseSellIn(this);

            InventoryManager.ResetQualityIfExpired(this);
        }
    }
}