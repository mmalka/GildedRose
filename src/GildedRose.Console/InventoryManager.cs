using System.Collections.Generic;

namespace GildedRose.Console
{
    public class InventoryManager
    {
        public static IList<Item> Inventory { get; set; }

        public static void UpdateQuality()
        {
            foreach (Item currentItem in Inventory)
            {
                UpdateItem(currentItem);
            }
        }

        private static void UpdateItem(Item currentItem)
        {
            if (currentItem is ICanSelfUpdate updateableItem)
            {
                updateableItem.Update();
            }
        }

        public static void ResetQualityIfExpired(Item currentItem)
        {
            if (currentItem.SellIn < 0)
            {
                currentItem.Quality = 0;
            }
        }

        public static void DecreaseQualityIfGreaterThanZero(Item currentItem)
        {
            if (currentItem.Quality > 0)
            {
                currentItem.Quality--;
            }
        }

        public static void IncreaseQualityIfLowerThanFifty(Item currentItem)
        {
            if (currentItem.Quality < 50)
            {
                currentItem.Quality++;
            }
        }

        public static void DecreaseSellIn(Item currentItem)
        {
            currentItem.SellIn--;
        }
    }
}