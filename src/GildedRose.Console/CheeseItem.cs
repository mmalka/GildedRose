namespace GildedRose.Console
{
    public class CheeseItem : Item, ICanSelfUpdate
    {
        public void Update()
        {
            InventoryManager.IncreaseQualityIfLowerThanFifty(this);

            InventoryManager.DecreaseSellIn(this);

            if (SellIn < 0)
            {
                InventoryManager.IncreaseQualityIfLowerThanFifty(this);
            }
        }
    }
}