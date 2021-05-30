using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
   public enum ItemType
    {
        Coin,
        HealthPoition,
        Boost
    }
    public ItemType itemType;
    public int amount;
}
