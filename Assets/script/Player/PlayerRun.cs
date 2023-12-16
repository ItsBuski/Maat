using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRun : MonoBehaviour
{
    [SerializeField] float playerSpeed;


    [Header("Events")]
    [Space]

    public UnityEvent OnRunEvent;
 
    void Update()
    {
        //movimiento
        GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed * Input.GetAxisRaw("Horizontal"), GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetAxisRaw("Horizontal") == 1) GetComponent<SpriteRenderer>().flipX = false;
        if (Input.GetAxisRaw("Horizontal") == -1) GetComponent<SpriteRenderer>().flipX = true;

        OnRunEvent.Invoke();

    }
 
 }


