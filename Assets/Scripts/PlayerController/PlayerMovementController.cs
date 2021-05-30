using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementController : MonoBehaviour
{
    public float speedMultiplier;
    Rigidbody2D rb2d;
    float horizontal;
    float vertical;
    public static int itemCount=0;
    public Text itemCountText;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector3(horizontal * speedMultiplier, vertical * speedMultiplier, 0);
    }
}
