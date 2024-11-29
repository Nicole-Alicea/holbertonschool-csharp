using System;

/// <summary>
/// Class that inherits from Base class.
/// </summary>
public class Inventory : BaseClass
{
    // Required properties
    public string user_id { get; set; }
    public string item_id { get; set; }
    public int quantity { get; set; }

    // Constructor
    public Inventory(string user_id, string item_id, int quantity = 1)
    {
        if (string.IsNullOrWhiteSpace(user_id))
            throw new ArgumentException("User ID is required.");
        if (string.IsNullOrWhiteSpace(item_id))
            throw new ArgumentException("Item ID is required.");
        if (quantity < 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be less than 0.");

        this.user_id = user_id;
        this.item_id = item_id;
        this.quantity = quantity;
    }
}

