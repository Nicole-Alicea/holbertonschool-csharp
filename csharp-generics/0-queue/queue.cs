using System;

/// <summary>
/// Class for Queue operations.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// Checks and returns the Queue's type.
    /// </summary>
    /// <returns>
    /// The Queue's type.
    /// </returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
