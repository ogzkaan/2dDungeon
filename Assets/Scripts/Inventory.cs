using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> itemList;
    public Inventory()
    {
        itemList = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.Coin, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Boost, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.HealthPoition, amount = 1 });
    }
    public void AddItem(Item item) 
    {
        itemList.Add(item);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
