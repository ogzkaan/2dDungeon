using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletcionController : MonoBehaviour
{
    Inventory inventory;
    private void Awake()
    {
        inventory = new Inventory();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
          
        }
    }
}
