using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    public Transform itemContainer;
    public Transform itemTemplate;

    private void Awake()
    {
        itemContainer = transform.Find("ItemContainer");
        itemTemplate = itemContainer.Find("ItemTemplate");

    }
   
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }
    private void RefreshInventoryItems()
    {
        float x = 1;
        float y = -0.8f;
        float itemSlotCellSize = 65f;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemTemplate, itemContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
        }
    }

}
