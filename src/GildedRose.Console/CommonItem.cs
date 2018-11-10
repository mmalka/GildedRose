namespace GildedRose.Console
{
    public class CommonItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            InventoryManager.DecreaseQuality(this);

            InventoryManager.DecreaseSellIn(this);

            if (SellIn < 0)
            {
                InventoryManager.DecreaseQuality(this);
            }
        }
    }
}