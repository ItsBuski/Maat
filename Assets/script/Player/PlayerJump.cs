using UnityEngine;
using System.Collections;
using static UnityEngine.UI.Image;
using UnityEngine.Events;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float JumpForce;
    [SerializeField] float lineLength;
    [SerializeField] float offset;
    [SerializeField] bool OnGround;
    [SerializeField] bool DoubleJump;
    public bool CanDoubleJump;


    [Header("Events")]
    [Space]

    public UnityEvent OnJumpEvent;
    public UnityEvent OnFallEvent;

    void Update()
    {
        CanDoubleJump = true;
        Vector2 origin = new Vector2(transform.position.x, transform.position.y - offset);
        Vector2 target = new Vector2(transform.position.x, transform.position.y - offset - lineLength);
        Debug.DrawLine(origin, target, Color.black);
        OnGround = Physics2D.Raycast(origin, Vector2.down, lineLength);
        RaycastHit2D raycast = Physics2D.Raycast(origin, Vector2.down, lineLength);
        if (OnGround)
        {
            DoubleJump = false;
            OnFallEvent.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnGround)
            {
                Jump();
                Debug.Log("Jump");
            }
            else if (CanDoubleJump && !DoubleJump)
            {
                Jump();
                DoubleJump = true;
                Debug.Log("JumpDouble");
            }

        }
    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpForce);
        OnJumpEvent.Invoke();
    }



}
