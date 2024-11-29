using System;

/// <summary>
/// Class that inherits from Base class.
/// </summary>
public class User : BaseClass
{
    // Required property
    public string name { get; set; }

    // Constructor
    public User(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.");

        this.name = name;
    }
}
