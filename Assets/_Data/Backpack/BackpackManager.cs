using System.Collections.Generic;
using UnityEngine;

public class BackpackManager : MonoBehaviour
{
    public int width = 5;
    public int height = 6;
    private Item[,] grid;
    public List<Item> inventory = new List<Item>();

    void Start()
    {
        grid = new Item[width, height];
    }

    public bool AddItem(Item item, Vector2Int position)
    {
        if (CanPlaceItem(item, position))
        {
            inventory.Add(item);
            return true;
        }
        return false;
    }

    private bool CanPlaceItem(Item item, Vector2Int position)
    {
        for (int x = 0; x < item.size.x; x++)
        {
            for (int y = 0; y < item.size.y; y++)
            {
                if (position.x + x >= width || position.y + y >= height || grid[position.x + x, position.y + y] != null)
                {
                    return false;
                }
            }
        }
        return true;
    }
}