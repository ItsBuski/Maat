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
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
    }
    public void Idle()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));
    }

    public void Jump()
    {
        animator.SetBool("jump", true);
    }

    public void Land()
    {
        animator.SetBool("jump", false);
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
        animator.SetTrigger("Dash");
    }

    public void StrongAttack()
    {
        animator.SetBool("jump", false);
        animator.SetTrigger("strongAttack");
    }

}

