using UnityEngine;
using System.Collections;
using static UnityEngine.UI.Image;

public class Jump : MonoBehaviour
{
    [SerializeField] float JumpForce;
    [SerializeField] float lineLength;
    [SerializeField] float offset;
    [SerializeField] bool OnGround;
    [SerializeField] bool DoubleJump;

    void Start()
    {

    }
    void Update()
    {
        Vector2 origin = new Vector2(transform.position.x, transform.position.y - offset);
        Vector2 target = new Vector2(transform.position.x, transform.position.y - offset - lineLength);
        Debug.DrawLine(origin, target, Color.black);
        OnGround = Physics2D.Raycast(origin, Vector2.down, lineLength);
        if (OnGround)
        {
            DoubleJump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnGround)
            {
                Jump();
            }
            else if (!DoubleJump)
            {
                Jump();
                DoubleJump = true;
            }
        }
    void Jump()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,
             JumpForce);
        }
    }
}