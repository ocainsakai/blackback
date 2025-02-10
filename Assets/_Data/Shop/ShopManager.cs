using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public List<Item> shopItems;

    public Item BuyItem(int index)
    {
        if (index >= 0 && index < shopItems.Count)
        {
            return shopItems[index];
        }
        return null;
    }
}
