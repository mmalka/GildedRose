using System.Collections.Generic;

namespace GildedRose.Console
{
    public class InventoryManager
    {
        public static IList<Item> Inventory { get; set; }

        public static void UpdateQuality()
        {
            for (var i = 0; i < Inventory.Count; i++)
            {
                if (Inventory[i].Name != "Aged Brie" && Inventory[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Inventory[i].Quality > 0)
                    {
                        if (Inventory[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Inventory[i].Quality = Inventory[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Inventory[i].Quality < 50)
                    {
                        Inventory[i].Quality = Inventory[i].Quality + 1;

                        if (Inventory[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Inventory[i].SellIn < 11)
                            {
                                if (Inventory[i].Quality < 50)
                                {
                                    Inventory[i].Quality = Inventory[i].Quality + 1;
                                }
                            }

                            if (Inventory[i].SellIn < 6)
                            {
                                if (Inventory[i].Quality < 50)
                                {
                                    Inventory[i].Quality = Inventory[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Inventory[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Inventory[i].SellIn = Inventory[i].SellIn - 1;
                }

                if (Inventory[i].SellIn < 0)
                {
                    if (Inventory[i].Name != "Aged Brie")
                    {
                        if (Inventory[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Inventory[i].Quality > 0)
                            {
                                if (Inventory[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Inventory[i].Quality = Inventory[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Inventory[i].Quality = Inventory[i].Quality - Inventory[i].Quality;
                        }
                    }
                    else
                    {
                        if (Inventory[i].Quality < 50)
                        {
                            Inventory[i].Quality = Inventory[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}