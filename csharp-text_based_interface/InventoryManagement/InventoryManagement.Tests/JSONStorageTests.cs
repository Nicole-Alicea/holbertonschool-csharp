using Xunit;
using InventoryLibrary;
using System.IO;

public class JSONStorageTests
{
    [Fact]
    public void JSONStorage_Should_Add_New_Object()
    {
        // Arrange
        var storage = new JSONStorage();
        var item = new Item { name = "Test Item" };

        // Act
        storage.New(item);

        // Assert
        Assert.Contains("Item." + item.id, storage.All());
    }

    [Fact]
    public void JSONStorage_Should_Save_And_Load_Data()
    {
        // Arrange
        var storage = new JSONStorage();
        var item = new Item { name = "Test Item" };
        storage.New(item);
        storage.Save();

        // Clear objects and reload
        storage.Load();

        // Assert
        Assert.Contains("Item." + item.id, storage.All());
    }

    [Fact]
    public void JSONStorage_Should_Create_Storage_File()
    {
        // Arrange
        var storage = new JSONStorage();

        // Act
        storage.Save();

        // Assert
        Assert.True(File.Exists("storage/inventory_manager.json"));
    }
}
