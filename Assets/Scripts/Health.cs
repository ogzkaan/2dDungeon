using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public  int health;

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        
    }
    public  void Heal(int healAmount)
    {
        health += healAmount; 
    }
    protected virtual void HitFeedBack()
    {
        Debug.Log("Hitted");
    }
    protected virtual void OnDeath()
    {
        Debug.Log("Deead");
    }
    protected bool CheckIfDead()
    {
        if (health<=0)
        {
            health = 0;
            return true;
        }
        else
        {
            return false;
        }
    }
}
