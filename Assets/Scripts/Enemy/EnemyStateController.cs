using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateController : MonoBehaviour
{
    public enum EnemyState
    {
        Wander,

        Follow,

        Die,

        Attack

    };

    EnemyMovementController enemyMovementController;
    EnemyCombatController enemyCombatController;

    public GameObject player;

    public EnemyState currentState = EnemyState.Wander;
    //private bool checkDead = false;
    private void Awake()
    {
        enemyMovementController = GetComponent<EnemyMovementController>();
        enemyCombatController = GetComponent<EnemyCombatController>();
    }

    void Update()
    {
        StateSwitch();
        AttackRangeCheck();
    }

    private void StateSwitch()
    {
        switch (currentState)
        {
            case (EnemyState.Wander):
                enemyMovementController.Wander();
            break;
            case (EnemyState.Follow):
                enemyMovementController.Follow();
            break;
            case (EnemyState.Die):
               //Die();
            break;
            case (EnemyState.Attack):
                enemyCombatController.Attack();
           break;

        }
        if (IsPlayerInRange(enemyMovementController.range) && currentState != EnemyState.Die)
        {
            currentState = EnemyState.Follow;
        }
        else 
        {
            currentState = EnemyState.Wander;
        }
    }
    private void AttackRangeCheck()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= enemyCombatController.attackRange)
        {
            currentState = EnemyState.Attack;
        }
    }
    private bool IsPlayerInRange(float range)
    {

        return Vector3.Distance(transform.position, player.transform.position) <= range;
    }



}
