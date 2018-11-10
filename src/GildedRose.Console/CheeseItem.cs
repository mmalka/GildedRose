namespace GildedRose.Console
{
    public class CheeseItem : Item, ICanSelfUpdate
    {
        public void Update()
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