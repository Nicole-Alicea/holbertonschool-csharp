using System;

/// <summary> A public class for the player. </summary>
class Player
{
        private string name;
        private float maxHp;
        private float hp;

        /// <summary> Constructor </summary>
        /// <param name="name"> The player's name. </param>
        /// <param name="maxHp"> The player's maximum health points. </param>
        public Player(string name = "Player", float maxHp = 100f)
        {
            if (maxHp <= 0f)
            {
                this.maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            else
            {
                this.maxHp = maxHp;
            }
            this.name = name;
            this.hp = this.maxHp;
        }

        /// <summary> Prints the player's health. </summary>
        public void PrintHealth()
        {
            Console.WriteLine($"{name} has {hp} / {maxHp} health");
        }
}