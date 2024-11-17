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

/// <summary>
/// Interface for objects that can be interacted with.
/// </summary>
interface IInteractive
{
    /// <summary>
    /// Method to interact with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for objects that can be broken.
/// </summary>
interface IBreakable
{
    /// <summary>
    /// Property that represents the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method to break the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for objects that can be collected.
/// </summary>
interface ICollectable
{
    /// <summary>
    /// Property that indicates if the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method to collect the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// A class that represents a Door.
/// </summary>
class Door : Base, IInteractive
{
    public Door(string n = "Door")
    {
        name = n;
    }

    /// <summary>
    /// Takes place when the object interacts with something.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// A class that represents a decoration.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Takes place when the object interacts with something.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }

        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }

        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Checks if the object has been broken.
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }

        if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }

        if (durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// A class that represents a Key.
/// </summary>
class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Takes place when the object interacts with something.
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }

        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}