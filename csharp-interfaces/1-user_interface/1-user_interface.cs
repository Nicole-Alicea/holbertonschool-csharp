using System;

///<summary>Base class</summary>
abstract class Base
{
  public string name = "";

	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

/// <summary> Interactive interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable Interface </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Collectable Interface </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();

}

/// <summary> Class that inherits from Base class and all interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability { get; set; }
	public bool isCollected { get; set; }

    /// <summary> Takes place when the object interacts with something </summary>
	public void Interact()
	{

	}

    /// <summary> Takes place when the object brakes. </summary>
	public void Break()
	{

	}

    /// <summary> Takes place when the object collects something.</summary>
	public void Collect()
	{

	}
}




// using System;

// /// <summary>
// /// Represents a base class with a name property and a custom string representation.
// /// </summary>
// abstract class Base
// {
//     public string name = "";

//     /// <summary>
//     /// Returns a string representation of the object.
//     /// </summary>
//     /// <returns>A string indicating the name and type of the object.</returns>
//     public override string ToString()
//     {
//         return (this.name + " is a " + this.GetType().ToString());
//     }
// }

// /// <summary>
// /// Interface for objects that can be interacted with.
// /// </summary>
// interface IInteractive
// {
//     /// <summary>
//     /// Method to interact with the object.
//     /// </summary>
//     void Interact();
// }

// /// <summary>
// /// Interface for objects that can be broken.
// /// </summary>
// interface IBreakable
// {
//     /// <summary>
//     /// Property that represents the durability of the object.
//     /// </summary>
//     int durability { get; set; }

//     /// <summary>
//     /// Method to break the object.
//     /// </summary>
//     void Break();
// }

// /// <summary>
// /// Interface for objects that can be collected.
// /// </summary>
// interface ICollectable
// {
//     /// <summary>
//     /// Property that indicates if the object has been collected.
//     /// </summary>
//     bool isCollected { get; set; }

//     /// <summary>
//     /// Method to collect the object.
//     /// </summary>
//     void Collect();
// }

// /// <summary>
// /// A class that represents a test object which can be interacted with, broken, and collected.
// /// </summary>
// class TestObject : Base, IInteractive, IBreakable, ICollectable
// {
//     public int durability { get; set; }
//     public bool isCollected { get; set; }

//     /// <summary>
//     /// Takes place when the object interacts with something.
//     /// </summary>
//     public void Interact()
//     {
        
//     }

//     /// <summary>
//     /// Takes place when the object breaks.
//     /// </summary>
//     public void Break()
//     {
        
//     }

//     /// <summary>
//     /// Takes place when the object collects something.
//     /// </summary>
//     public void Collect()
//     {
        
//     }
// }