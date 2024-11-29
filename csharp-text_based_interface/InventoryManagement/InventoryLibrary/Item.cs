using System;
using System.Collections.Generic;

/// <summary>
/// Class that inherits from Base class.
/// </summary>
public class Item : BaseClass
{
    // Required property
    public string name { get; set; }

    // Optional properties
    public string description { get; set; }
    public float price { get; set; }
    public List<string> tags { get; set; }

    // Constructor
    public Item(string name, float price = 0.0f, string description = null, List<string> tags = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.");
            
        this.name = name;
        this.description = description;
        this.price = (float)Math.Round(price, 2); // Limit to 2 decimal points
        this.tags = tags ?? new List<string>();
    }
}
