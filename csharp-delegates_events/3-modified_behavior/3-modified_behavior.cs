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

    delegate void CalculateHealth(float damage);

    /// <summary>
    /// Handles the damage the player takes.
    /// </summary>
    /// <param name="damage"> The amount of damage the player takes. </param>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            damage = 0f;
        }

        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
        }

        this.hp -= damage;
        ValidateHP(this.hp);
    }

    /// <summary>
    /// Handles the player's healing.
    /// </summary>
    /// <param name="heal"> The amount the player will heal. </param>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            heal = 0f;
        }

        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
        }

        this.hp += heal;
        ValidateHP(this.hp);
    }

    /// <summary>
    /// Changes the player's HP to the appropriate one depending on the damage or healing taken.
    /// </summary>
    /// <param name="newHp"> The player's new HP value. </param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }

        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }

        else
        {
            this.hp = newHp;
        }
    }

    /// <summary>
    /// Applies a modifier to an attack.
    /// </summary>
    /// <param name="baseValue"> The normal attack power of the player. </param>
    /// <param name="modifier"> Modifies the attack power of the player. </param>
    /// <returns> The attack power. </returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue * 0.5f;
        }

        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }

        else
        {
            return baseValue * 1.5f;
        }
    }
}

enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// Determines the strength of the attack modifier.
/// </summary>
/// <param name="baseValue"> Normal attack. </param>
/// <param name="modifier"> Modifier that will be applied to the base value. </param>
delegate float CalculateModifier(float baseValue, Modifier modifier);