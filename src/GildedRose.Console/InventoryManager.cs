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
            if (currentItem.Name == "Aged Brie" || currentItem.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (currentItem.Quality < 50)
                {
                    currentItem.Quality = currentItem.Quality + 1;
                }

                if (currentItem.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (currentItem.Quality < 50)
                    {
                        if (currentItem.SellIn < 11)
                        {
                            if (currentItem.Quality < 50)
                            {
                                currentItem.Quality = currentItem.Quality + 1;
                            }
                        }

                        if (currentItem.SellIn < 6)
                        {
                            if (currentItem.Quality < 50)
                            {
                                currentItem.Quality = currentItem.Quality + 1;
                            }
                        }
                    }
                }
            }
            else
            {
                if (currentItem.Name == "Sulfuras, Hand of Ragnaros")
                {
                    if (currentItem.Quality > 0)
                    {
                    }
                }
                else
                {
                    if (currentItem.Quality > 0)
                    {
                        currentItem.Quality = currentItem.Quality - 1;
                    }
                }
            }

            if (currentItem.Name == "Sulfuras, Hand of Ragnaros")
            {
            }
            else
            {
                currentItem.SellIn = currentItem.SellIn - 1;
            }

            if (currentItem.Name == "Aged Brie")
            {
                if (currentItem.SellIn < 0)
                {
                    if (currentItem.Quality < 50)
                    {
                        currentItem.Quality = currentItem.Quality + 1;
                    }
                }
            }
            else
            {
                if (currentItem.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (currentItem.SellIn < 0)
                    {
                        currentItem.Quality = currentItem.Quality - currentItem.Quality;
                    }
                }
                else
                {
                    if (currentItem.SellIn < 0)
                    {
                        if (currentItem.Quality > 0)
                        {
                            if (currentItem.Name == "Sulfuras, Hand of Ragnaros")
                            {
                                return;
                            }

                            currentItem.Quality = currentItem.Quality - 1;
                        }
                    }
                }
            }
        }
    }
}