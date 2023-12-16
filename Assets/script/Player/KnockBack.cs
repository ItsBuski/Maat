using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnockBack : MonoBehaviour
{
    private  Rigidbody2D rb2d;

    [Header("Knockback")]
    [SerializeField] float KnockbackForce = 50;

    private Vector3 direction;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb2d != null)
        {
            direction =  collision.transform.position - transform.position;
            direction.y = .1f;
        }
    }

    public void KnockBackEffect()
    {

            rb2d.AddForce(direction.normalized * KnockbackForce, ForceMode2D.Impulse);
        Debug.Log("Knocback");
              
    }
}
