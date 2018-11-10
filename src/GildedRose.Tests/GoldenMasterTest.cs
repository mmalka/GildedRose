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
                new Item
                {
                    Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20
                },
                new Item
                {
                    Name = "Aged Brie", SellIn = 2, Quality = 0
                },
                new Item
                {
                    Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7
                },
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20
                },
                new Item
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
                for (int itemIndex = 0, itemCount = LegacyInventoryManager.Inventory.Count; itemIndex < itemCount; itemIndex++)
                {
                    LegacyInventoryManager.UpdateQuality();
                    InventoryManager.UpdateQuality();

                    Assert.Equal(LegacyInventoryManager.Inventory[itemIndex].Quality, InventoryManager.Inventory[itemIndex].Quality);
                }
            }
        }
    }
}