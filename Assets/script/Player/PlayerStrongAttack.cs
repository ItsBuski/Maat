using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStrongAttack : MonoBehaviour
{
    [SerializeField] Transform attackPoint;
    [SerializeField] float attackRange;
    [SerializeField] LayerMask enemyLayers;

    [Header("Events")]
    [Space]

    public UnityEvent OnStrongAttackEvent;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            OnStrongAttack();
        }
    }
    void OnStrongAttack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        OnStrongAttackEvent.Invoke();

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<PlayerStats>().TakeDamage(1);
            enemy.GetComponent<KnockBack>().KnockBackEffect();
            Debug.Log("hitted");
        }

    }
}
