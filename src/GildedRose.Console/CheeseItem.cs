namespace GildedRose.Console
{
    public class CheeseItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            if (Name == "Aged Brie")
            {
                InventoryManager.IncreaseQuality(this);

                InventoryManager.DecreaseSellIn(this);

                if (SellIn < 0)
                {
                    InventoryManager.IncreaseQuality(this);
                }
            }
        }
    }
}