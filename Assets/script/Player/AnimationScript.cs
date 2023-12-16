using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private Animator animator;
    private float horizontalMovement;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontalMovement = Mathf.Abs(Input.GetAxis("Horizontal"));
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
    }
    public void Idle()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
    }

    public void Jump()
    {
        animator.SetBool("jump", true);
        animator.SetBool("Crouch", false);
    }

    public void Land()
    {
        animator.SetBool("jump", false);
    }

    public void Crouch()
    {
        animator.SetBool("Crouch", true);
        animator.SetBool("idle", false);
        animator.SetBool("jump", false);
    }

    public void Stand()
    {
        animator.SetBool("Crouch", false);
        animator.SetBool("idle", true);
        animator.SetBool("jump", false);
    }

    public void Attack()
    {
            animator.SetBool("jump", false);
            animator.SetTrigger("attack");
    }

    public void StrongAttack()
    {
        animator.SetBool("jump", false);
        animator.SetTrigger("strongAttack");
    }

    public void Victory()
    {
        animator.SetTrigger("Victory");
    }

    public void isClimbing()
    {
        animator.SetBool("isClimbing", true);
    }

    public void stopClimbing()
    {
        animator.SetBool("isClimbing", false);
    }

}

