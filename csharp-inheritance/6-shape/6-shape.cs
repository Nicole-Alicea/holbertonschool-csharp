﻿using System;

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

/// <summary>
/// Class that inherits from class Shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// public property Width
    /// get: retrieves the width
    /// set: sets the width or throws exception if value is negative
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// public property Height
    /// get: retrieves the height
    /// set: sets the height or throws an exception if value is negative
    /// </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
}