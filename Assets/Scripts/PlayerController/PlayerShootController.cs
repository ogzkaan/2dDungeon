using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootController : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float shootSpeed;

    public float shootDelay;
    private float lastShoot;

    private float horizontalShoot;
    private float verticalShoot;
    private void Update()
    {
        horizontalShoot = Input.GetAxis("HorizontalShoot");
        verticalShoot = Input.GetAxis("VerticalShoot");
        
        ShootCondition();
          
       
    }
    private void ShootCondition()
    {
        
        if ( (verticalShoot!=0 || horizontalShoot!=0)  && Time.time > lastShoot+shootDelay)
        {
            ShootBullet(horizontalShoot, verticalShoot);
            lastShoot = Time.time;
        }
    }
    private void ShootBullet(float x,float y)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(
            (x < 0) ? Mathf.Floor(x) * shootSpeed : Mathf.Ceil(x) * shootSpeed,
            (y < 0) ? Mathf.Floor(y) * shootSpeed : Mathf.Ceil(y) * shootSpeed,
            0);
    }
    
}
