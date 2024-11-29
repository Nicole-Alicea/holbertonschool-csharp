using Xunit;
using InventoryLibrary;

public class UserTests
{
    [Fact]
    public void User_Should_Initialize_With_Name()
    {
        // Arrange
        var user = new User { name = "Test User" };

        // Act & Assert
        Assert.Equal("Test User", user.name);
    }
}
