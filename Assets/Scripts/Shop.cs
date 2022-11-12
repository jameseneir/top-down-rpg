using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Item[] items;

    public GameObject itemSlotPrefab;

    private void Start()
    {
        if (items == null)
            return;
        foreach (Item item in items)
        {
            GameObject itemSlot = Instantiate(itemSlotPrefab, transform);
            itemSlot.GetComponent<ItemSlotUI>().SetUp(item);
        }
    }
}
