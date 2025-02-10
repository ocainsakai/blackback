using UnityEngine;

public class Character
{
    public string characterName;
    public int health;
    public int attack;
    public int defense;

    public Character(string name, int hp, int atk, int def)
    {
        characterName = name;
        health = hp;
        attack = atk;
        defense = def;
    }

    public void TakeDamage(int damage)
    {
        int finalDamage = Mathf.Max(damage - defense, 0);
        health -= finalDamage;
        Debug.Log(characterName + " nhận " + finalDamage + " sát thương!");
    }
}

