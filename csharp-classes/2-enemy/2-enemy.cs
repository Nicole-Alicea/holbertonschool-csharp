﻿namespace Enemies
{
    /// <summary> Defines a zombie. </summary>
    public class Zombie
    {
        /// <summary> The zombie's health. </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// Sets the health of the zombie to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie" class with a specified health value./> 
        /// </summary>
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
    }
}