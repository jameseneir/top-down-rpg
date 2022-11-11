using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Customer : MonoBehaviour, IShopCustomer
{
    int currentGold;

    public int GetCurrentGold()
    {
        return currentGold;
    }

    public bool TryBuyItem(Item item)
    {
        if (item.price > currentGold)
            return false;
        else
        {
            currentGold -= item.price;
            //Equip item
            return true;
        }
    }
}
