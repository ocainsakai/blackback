using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public Sprite icon;
    public Vector2Int size; // Kích thước item trong ba lô
    public int attackPower;
    public int defensePower;
    public bool isStackable;
}
