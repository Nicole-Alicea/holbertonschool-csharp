using System;

namespace Enemies
{
    /// <summary> Defines a zombie. </summary>
    public class Zombie
    {
        private int health; // Private field that stores the health of the zombie.
        private string name = "(No name)"; // Private field that stores the name of the zombie.

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// Sets the health of the zombie to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary> Initializes a new instance of the <see cref="Zombie"/> class with a specified health value. </summary>
        /// <param name="value"> The initial health of the zombie. Must be greater than or equal to 0. </param>
        /// <exception cref="ArgumentException"> Thrown when the value is less than 0. </exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary> Returns the health value of a Zombie object. </summary>
        /// <returns> The value of health of the Zombie object. </returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary> Retrieves and sets the name value of the zombie. </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}