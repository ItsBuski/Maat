using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGomba : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] bool direction;
    Rigidbody2D rb;

    [SerializeField] float timer;
    [SerializeField] float maxTimer;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        timer = maxTimer;
    }


    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            direction = !direction;
            timer = maxTimer;
        }

        if (direction)
        {

            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;


        }

        if (!direction)
        {

            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

}
