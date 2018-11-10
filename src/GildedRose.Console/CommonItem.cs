namespace GildedRose.Console
{
    public class CommonItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            InventoryManager.DecreaseQualityIfGreaterThanZero(this);

            InventoryManager.DecreaseSellIn(this);

            if (SellIn < 0)
            {
                InventoryManager.DecreaseQualityIfGreaterThanZero(this);
            }
        }
    }
}