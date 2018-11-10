namespace GildedRose.Console
{
    public class ConcertPassItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            if (Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                InventoryManager.IncreaseQuality(this);

                if (Quality < 50)
                {
                    if (SellIn < 11)
                    {
                        InventoryManager.IncreaseQuality(this);
                    }

                    if (SellIn < 6)
                    {
                        InventoryManager.IncreaseQuality(this);
                    }
                }
                SellIn = SellIn - 1;

                InventoryManager.ResetQuality(this);
            }
        }
    }
}