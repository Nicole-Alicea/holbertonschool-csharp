using System;
using System.Reflection;

/// <summary>
/// A class for inspecting an object's properties and methods.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        // This gets the type of the object
        Type type = myObj.GetType();

        // This prints the type name followed by "Properties:"
        Console.WriteLine($"{type.Name} Properties:");

        // This will iterate through each property and print its name
        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        // This prints the type name followed by "Methods:"
        Console.WriteLine($"{type.Name} Methods:");

        // This will iterate through each method and print its name
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}