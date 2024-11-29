using Xunit;
using InventoryLibrary;

public class BaseClassTests
{
    [Fact]
    public void BaseClass_Should_Initialize_Properties()
    {
        // Arrange
        var obj = new BaseClass();

        // Act & Assert
        Assert.NotNull(obj.id);
        Assert.True(obj.date_created <= DateTime.Now);
        Assert.True(obj.date_updated <= DateTime.Now);
    }
}
