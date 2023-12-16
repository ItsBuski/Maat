using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    private Transform player;

    [SerializeField] float speed;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);


        if (distanceFromPlayer > 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

        if (distanceFromPlayer > 15)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime * 7);
        }
    }
}
