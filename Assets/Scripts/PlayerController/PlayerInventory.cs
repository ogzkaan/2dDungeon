using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;
    public UI_Inventory uiInventory;
    private void Awake()
    {
        inventory = new Inventory();

        uiInventory.SetInventory(inventory);
    }
}
