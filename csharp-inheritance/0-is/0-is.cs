using System;

/// <summary>
/// A class that checks the type of an object.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the provided object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is of type int; otherwise, false.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}