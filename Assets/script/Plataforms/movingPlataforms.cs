using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlataforms : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float distance; 
    Vector2 originalPosition; 
    bool rightMotion = true;

    public void Start()
    {
        originalPosition = transform.position;
    }


    public void FixedUpdate()
    {
        if ((transform.position.x < (originalPosition.x + distance)) && rightMotion)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else if ((transform.position.x >= (originalPosition.x + distance)) && rightMotion) rightMotion = false;

        if ((transform.position.x > (originalPosition.x - distance)) && !rightMotion)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if ((transform.position.x <= (originalPosition.x - distance)) && !rightMotion) rightMotion = true;
    }
}
