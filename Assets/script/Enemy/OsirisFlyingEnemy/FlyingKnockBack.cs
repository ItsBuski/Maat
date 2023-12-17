using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingKnockBack : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private GameObject player;
    float distanceFromPlayer;
    float timer;
    [SerializeField] float maxTimer;
    Vector3 newPosition;
    [SerializeField] bool floorEnemy;

    private Vector3 direction;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb2d != null)
        {
            direction = collision.transform.position - transform.position;
            direction.y = .1f;
        }
    }

    private void Update()
    {

        timer += Time.deltaTime;

        if (timer > 0.25)
        {
            distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
        }

        if (timer < 0.25)
        {
            if (!floorEnemy)
            {
                transform.position = Vector3.MoveTowards(transform.position, newPosition, 0.25f);
            }
            
        }
        
    }

    public void FlyingKnockBackEffect()
    {
        newPosition = new Vector3(transform.position.x + distanceFromPlayer, transform.position.y, transform.position.z);
        floorEnemy = false;
        timer = maxTimer;
        Debug.Log("Knocback");

    }
}
