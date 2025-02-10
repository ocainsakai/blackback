using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Character player;
    public Character enemy;

    void Start()
    {
        player = new Character("Người chơi", 100, 10, 5);
        enemy = new Character("Kẻ địch", 80, 8, 3);
        StartBattle();
    }

    void StartBattle()
    {
        while (player.health > 0 && enemy.health > 0)
        {
            enemy.TakeDamage(player.attack);
            if (enemy.health <= 0) break;
            player.TakeDamage(enemy.attack);
        }
        Debug.Log(player.health > 0 ? "Người chơi thắng!" : "Kẻ địch thắng!");
    }
}