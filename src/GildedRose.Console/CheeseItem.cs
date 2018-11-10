namespace GildedRose.Console
{
    public class CheeseItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            if (Name == "Aged Brie")
            {
                InventoryManager.IncreaseQuality(this);
                SellIn = SellIn - 1;

                if (SellIn < 0)
                {
                    InventoryManager.IncreaseQuality(this);
                }
            }
        }
    }
}