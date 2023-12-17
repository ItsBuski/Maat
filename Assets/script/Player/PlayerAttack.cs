using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Transform attackPoint;
    [SerializeField] float attackRange;
    [SerializeField] LayerMask enemyLayers;

    [Header("Events")]
    [Space]

    public UnityEvent OnAttackEvent;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            OnAttack();
        }
    }
    void OnAttack()
    {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            OnAttackEvent.Invoke();

            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<PlayerStats>().TakeDamage(1);
                Debug.Log("hitted");
            }
        
    }
}
