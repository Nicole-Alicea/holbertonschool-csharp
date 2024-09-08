using System;

/// <summary>
/// A class for checking instance types.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the given object is an instance of Array or a class that inherited from Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of Array or a derived class; otherwise, false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}