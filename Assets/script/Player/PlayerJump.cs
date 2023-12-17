using UnityEngine;
using System.Collections;
using static UnityEngine.UI.Image;
using UnityEngine.Events;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] bool OnGround;
    [SerializeField] bool DoubleJump;
    [SerializeField] GroundCheck groundCheck;
    [SerializeField] Rigidbody2D rb;


    [Header("Events")]
    [Space]

    public UnityEvent OnJumpEvent;
    public UnityEvent OnFallEvent;

    void Update()
    {
        if (groundCheck.isGrounded)
        {
            DoubleJump = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        } else {
            if(Input.GetKeyDown(KeyCode.Space)) {
                if(DoubleJump == true) {
                    Jump();
                    DoubleJump = false;
                }
            }
        }
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        OnJumpEvent.Invoke();
    }
}