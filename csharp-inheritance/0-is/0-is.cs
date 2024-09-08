using System;

public class Obj
{
    /// <summary>
    /// Checks if the provided object is of type <see cref="int"/>.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns><c>true</c> if the object is of type <see cref="int"/>; otherwise, <c>false</c>.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}