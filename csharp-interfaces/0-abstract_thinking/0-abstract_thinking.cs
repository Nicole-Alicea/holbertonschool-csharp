using System;

/// <summary>
/// Represents a base class with a name property and a custom string representation.
/// </summary>
abstract class Base
{
    public string name = "";

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A string indicating the name and type of the object.</returns>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}