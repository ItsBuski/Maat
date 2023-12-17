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
    Rigidbody2D rb;

    [SerializeField] float timer = 0;
    float delayBeforeLoad = 1.5f;

    [SerializeField] float timerFall;
    [SerializeField] float maxTimerFall;



    [Header("Events")]
    [Space]

    public UnityEvent OnJumpEvent;
    public UnityEvent OnFallEvent;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        

        if (groundCheck.isGrounded)
        {
            DoubleJump = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
                OnFallEvent.Invoke();
            }

        } else {
            if(Input.GetKeyDown(KeyCode.Space)) {
                if(DoubleJump == true) {
                    Jump();
                    DoubleJump = false;
                    OnFallEvent.Invoke();
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