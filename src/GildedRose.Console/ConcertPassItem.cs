namespace GildedRose.Console
{
    public class ConcertPassItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            if (Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                InventoryManager.IncreaseQuality(this);

                if (SellIn < 11)
                {
                    InventoryManager.IncreaseQuality(this);
                }

                if (SellIn < 6)
                {
                    InventoryManager.IncreaseQuality(this);
                }

                InventoryManager.DecreaseSellIn(this);

                InventoryManager.ResetQuality(this);
            }
        }
    }
}