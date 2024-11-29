using Xunit;
using InventoryLibrary;

public class ItemTests
{
    [Fact]
    public void Item_Should_Initialize_With_Name()
    {
        // Arrange
        var item = new Item { name = "Test Item" };

        // Act & Assert
        Assert.Equal("Test Item", item.name);
        Assert.Equal(0.0f, item.price); // Default value
    }

    [Theory]
    [InlineData(-10.0f)]
    [InlineData(-0.01f)]
    public void Item_Should_Reject_Negative_Price(float invalidPrice)
    {
        // Arrange
        var item = new Item();

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => item.price = invalidPrice);
    }
}
