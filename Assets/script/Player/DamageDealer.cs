using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] LayerMask masking;

    public int GetDamage()
    {
        return damage;
    }

    public void Hit()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("damaged");
            collision.gameObject.GetComponent<PlayerStats>().TakeDamage(damage);
        

    }
}
