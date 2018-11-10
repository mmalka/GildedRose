namespace GildedRose.Console
{
    public class CommonItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            InventoryManager.DecreaseQuality(this);

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                InventoryManager.DecreaseQuality(this);
            }
        }
    }
}