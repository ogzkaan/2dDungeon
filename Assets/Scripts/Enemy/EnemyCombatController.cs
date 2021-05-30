using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatController : MonoBehaviour
{
    public GameObject player;

    private bool coolDownAttack = false;

    public float coolDown;
    public float attackRange;
    public int attackDamage;
   
    public void Attack()
    {
        if (!coolDownAttack)
        {
            player.gameObject.GetComponent<IDamagable<int>>().TakeDamage(attackDamage);
            StartCoroutine(CoolDown());
        }

    }
    private IEnumerator CoolDown()
    {
        coolDownAttack = true;
        yield return new WaitForSeconds(coolDown);
        coolDownAttack = false;
    }
}
