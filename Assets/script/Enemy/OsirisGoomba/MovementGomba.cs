using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGomba : MonoBehaviour
{
    [SerializeField] Transform targetPosition1;
    [SerializeField] Transform targetPosition2;

    [SerializeField] float moveSpeed;
    [SerializeField] bool direction;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(direction);
        direction = !direction;
    }
    void Update()
    {
        if (direction)
        {
            Vector3 moveDirection = targetPosition1.position - transform.position;

            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
  
        }

        if (!direction)
        {
            Vector3 moveDirection = targetPosition2.position - transform.position;

            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }
}
