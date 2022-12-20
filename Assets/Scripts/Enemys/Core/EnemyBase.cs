using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public enum EnemyState
    {
        idle,
        moving,
        attacking
    }

    public float idleDistance, attackDistance, moveDistance;
    public GameObject target;
    public Enemy enemyController;

    public bool drawGizmos = true;
    public EnemyState currentState = EnemyState.idle;


    // Start is called before the first frame update
    void Start()
    {
        enemyController.target = target;
    }

    private void OnDrawGizmos()
    {
        if (drawGizmos)
        {

            Gizmos.color = Color.white;
            Gizmos.DrawWireSphere(transform.position, moveDistance);
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackDistance);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float distance = (target.transform.position - transform.position).magnitude;


            if (distance < moveDistance)
            {
                enemyController.Move();
                currentState = EnemyState.moving;
            }

            if (distance > moveDistance)
            {
                enemyController.Idle();
                currentState = EnemyState.idle;
            }

            if (distance < attackDistance)
            {
                enemyController.Attack();
                currentState = EnemyState.attacking;
            }
        }
    }
}
