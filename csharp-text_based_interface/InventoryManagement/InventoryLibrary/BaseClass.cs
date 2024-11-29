using System;

/// <summary>
/// Base class that all other classes will inherit from.
/// </summary>
public class BaseClass
{
    // Properties
    public string id { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }

    /// <summary>
    /// Sets the values for the properties specified above.
    /// </summary>
    public BaseClass()
    {
        this.id = id;
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}
