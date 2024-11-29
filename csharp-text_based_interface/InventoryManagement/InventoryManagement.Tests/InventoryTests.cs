using Xunit;
using InventoryLibrary;

public class InventoryTests
{
    [Fact]
    public void Inventory_Should_Have_Valid_Quantity()
    {
        // Arrange
        var inventory = new Inventory();

        // Act
        inventory.quantity = 5;

        // Assert
        Assert.Equal(5, inventory.quantity);
    }

    [Fact]
    public void Inventory_Should_Reject_Negative_Quantity()
    {
        // Arrange
        var inventory = new Inventory();

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => inventory.quantity = -1);
    }
}
