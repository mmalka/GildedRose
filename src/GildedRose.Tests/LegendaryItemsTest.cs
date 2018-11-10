using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class LegendaryItemsTest
    {
        private const int ExpectedSellIn = 0;
        private const int ExpectedQuality = 80;

        private readonly LegendaryItem _expectedLegendaryItem = new LegendaryItem()
        {
            Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = ExpectedQuality
        };

        [Fact]
        public void ShouldAlwaysKeepInitialQualityIfLegendary()
        {
            for (int i = 0; i < 100; i++)
            {
                _expectedLegendaryItem.Update();
            }

            Assert.Equal(ExpectedQuality, _expectedLegendaryItem.Quality);
        }

        [Fact]
        public void ShouldAlwaysKeepInitialSellInIfLegendary()
        {
            for (int i = 0; i < 100; i++)
            {
                _expectedLegendaryItem.Update();
            }

            Assert.Equal(ExpectedSellIn, _expectedLegendaryItem.SellIn);
        }
    }
}