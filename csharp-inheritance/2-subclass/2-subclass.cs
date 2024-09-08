using System;

/// <summary>
/// A class for type-checking methods.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the given derived type is a subclass of the specified base type.
    /// </summary>
    /// <param name="derivedType">The type to check if it's a subclass.</param>
    /// <param name="baseType">The base type to compare against.</param>
    /// <returns>True if the derived type is a subclass of the base type and not the base type itself; otherwise, false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}