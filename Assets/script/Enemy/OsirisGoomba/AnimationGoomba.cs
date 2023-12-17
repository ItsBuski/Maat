using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationGoomba : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }



    public void Attack()
    {
        animator.SetTrigger("attack");
    }

    public void Dead()
    {
        animator.SetTrigger("dead");
    }
}
