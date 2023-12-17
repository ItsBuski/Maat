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
        animator.SetTrigger("jump");
    }

    public void Fall()
    {
        animator.SetTrigger("fall");
    }

    public void Land()
    {
        animator.SetBool("idle", true);
    }

    public void Stand()
    {
        animator.SetBool("idle", true);
    }

    public void Attack()
    {
            animator.SetTrigger("attack");
    }

    public void Dash()
    {
        animator.SetTrigger("dash");
    }

    public void StrongAttack()
    {
        animator.SetTrigger("strongAttack");
    }

}

