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
            if (currentItem.Name == "Sulfuras, Hand of Ragnaros")
            {
                return;
            }

            if (currentItem.Name == "Aged Brie")
            {
                IncreaseQuality(currentItem);

                currentItem.SellIn = currentItem.SellIn - 1;

                if (currentItem.SellIn < 0)
                {
                    IncreaseQuality(currentItem);
                }

                return;
            }

            if (currentItem.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                IncreaseQuality(currentItem);

                if (currentItem.Quality < 50)
                {
                    if (currentItem.SellIn < 11)
                    {
                        IncreaseQuality(currentItem);
                    }

                    if (currentItem.SellIn < 6)
                    {
                        IncreaseQuality(currentItem);
                    }
                }

                currentItem.SellIn = currentItem.SellIn - 1;

                ResetQuality(currentItem);

                return;
            }

            DecreaseQuality(currentItem);

            currentItem.SellIn = currentItem.SellIn - 1;

            if (currentItem.SellIn < 0)
            {
                DecreaseQuality(currentItem);
            }
        }

        private static void ResetQuality(Item currentItem)
        {
            if (currentItem.SellIn < 0)
            {
                currentItem.Quality = currentItem.Quality - currentItem.Quality;
            }
        }

        private static void DecreaseQuality(Item currentItem)
        {
            if (currentItem.Quality > 0)
            {
                currentItem.Quality = currentItem.Quality - 1;
            }
        }

        private static void IncreaseQuality(Item currentItem)
        {
            if (currentItem.Quality < 50)
            {
                currentItem.Quality = currentItem.Quality + 1;
            }
        }
    }
}