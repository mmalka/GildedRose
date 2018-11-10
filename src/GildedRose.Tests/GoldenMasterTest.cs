using System.Collections.Generic;
using Xunit;
using GildedRose.Console;

namespace GildedRose.Tests
{
    public class GoldenMasterTest
    {
        private static IList<Item> GenerateStartingInnInventoryItems()
        {
            return new List<Item>
            {
                new CommonItem()
                {
                    Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20
                },
                new CheeseItem()
                {
                    Name = "Aged Brie", SellIn = 2, Quality = 0
                },
                new CommonItem
                {
                    Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7
                },
                new LegendaryItem()
                {
                    Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80
                },
                new ConcertPassItem()
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20
                },
                new CommonItem
                {
                    Name = "Conjured Mana Cake", SellIn = 3, Quality = 6
                }
            };
        }

        [Fact]
        public void ShouldAssertThatAllItemsQualityRemainsEqualAnHundredDayInARowWhileComparingAgainstLegacyVersionOutput()
        {
            LegacyInventoryManager.Inventory = GenerateStartingInnInventoryItems();

            InventoryManager.Inventory = GenerateStartingInnInventoryItems();

            for (int currentDay = 0; currentDay < 100; currentDay++)
            {
                for (int itemIndex = 0, itemCount = LegacyInventoryManager.Inventory.Count;
                    itemIndex < itemCount;
                    itemIndex++)
                {
                    LegacyInventoryManager.UpdateQuality();
                    InventoryManager.UpdateQuality();

                    Assert.Equal(LegacyInventoryManager.Inventory[itemIndex].Quality,
                        InventoryManager.Inventory[itemIndex].Quality);
                }
            }
        }

        [Fact]
        public void ShouldAssertThatAllItemsSellInRemainsEqualAnHundredDayInARowWhileComparingAgainstLegacyVersionOutput()
        {
            LegacyInventoryManager.Inventory = GenerateStartingInnInventoryItems();

            InventoryManager.Inventory = GenerateStartingInnInventoryItems();

            for (int currentDay = 0; currentDay < 100; currentDay++)
            {
                for (int itemIndex = 0, itemCount = LegacyInventoryManager.Inventory.Count;
                    itemIndex < itemCount;
                    itemIndex++)
                {
                    LegacyInventoryManager.UpdateQuality();
                    InventoryManager.UpdateQuality();

                    Assert.Equal(LegacyInventoryManager.Inventory[itemIndex].SellIn,
                        InventoryManager.Inventory[itemIndex].SellIn);
                }
            }
        }

        [Fact]
        public void ShouldAssertThatAllItemsNameRemainsEqualAnHundredDayInARowWhileComparingAgainstLegacyVersionOutput()
        {
            LegacyInventoryManager.Inventory = GenerateStartingInnInventoryItems();

            InventoryManager.Inventory = GenerateStartingInnInventoryItems();

            for (int currentDay = 0; currentDay < 100; currentDay++)
            {
                for (int itemIndex = 0, itemCount = LegacyInventoryManager.Inventory.Count;
                    itemIndex < itemCount;
                    itemIndex++)
                {
                    LegacyInventoryManager.UpdateQuality();
                    InventoryManager.UpdateQuality();

                    Assert.Equal(LegacyInventoryManager.Inventory[itemIndex].Name,
                        InventoryManager.Inventory[itemIndex].Name);
                }
            }
        }
    }
}