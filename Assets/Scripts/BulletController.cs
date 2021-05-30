using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float lifeTime;
    public int damage;
    void Start()
    {
        StartCoroutine(DeathDelay());
    }

   
    void Update()
    {
        
    }

    IEnumerator DeathDelay()
    {

        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<IDamagable<int>>()!=null && !collision.CompareTag("Player")) 
        {
            collision.GetComponent<IDamagable<int>>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
