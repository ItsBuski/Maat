using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private Animator animator;
    private float horizontalMovement;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        horizontalMovement = Mathf.Abs(Input.GetAxis("Horizontal"));
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));

    }
    public void Idle()
    {
        animator.SetBool("idle", true);
    }

    public void Jump()
    {
        animator.SetBool("jump", true);
    }

    public void Fall()
    {
        animator.SetTrigger("fall");
        animator.SetBool("jump", false);
    }

    public void Land()
    {
        animator.SetBool("jump", false);
        animator.SetBool("idle", true);
    }

    public void Stand()
    {
        animator.SetBool("idle", true);
        animator.SetBool("jump", false);
    }

    public void Attack()
    {
            animator.SetBool("jump", false);
            animator.SetTrigger("attack");
    }

    public void Dash()
    {
        animator.SetTrigger("dash");
    }

    public void StrongAttack()
    {
        animator.SetBool("jump", false);
        animator.SetTrigger("strongAttack");
    }

}

