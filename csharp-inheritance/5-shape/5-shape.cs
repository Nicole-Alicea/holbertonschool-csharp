using System;

/// <summary>
/// Class that represents a shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of a shape. Method not implemented in the base class.
    /// </summary>
    /// <returns>NotImplementedException</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}