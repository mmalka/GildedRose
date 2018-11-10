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

        public static void ResetQuality(Item currentItem)
        {
            if (currentItem.SellIn < 0)
            {
                currentItem.Quality = currentItem.Quality - currentItem.Quality;
            }
        }

        public static void DecreaseQuality(Item currentItem)
        {
            if (currentItem.Quality > 0)
            {
                currentItem.Quality = currentItem.Quality - 1;
            }
        }

        public static void IncreaseQuality(Item currentItem)
        {
            if (currentItem.Quality < 50)
            {
                currentItem.Quality = currentItem.Quality + 1;
            }
        }
    }
}