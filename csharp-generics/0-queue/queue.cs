using System;

/// <summary>
/// Class for Queue operations.
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Checks and returns the type of a Queue.
    /// </summary>
    /// <returns> A Queue's type. </returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}