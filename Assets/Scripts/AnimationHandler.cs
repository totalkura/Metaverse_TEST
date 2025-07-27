using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsMoving = Animator.StringToHash("IsMove");
    private static readonly int Front = Animator.StringToHash("Front");
    private static readonly int Back = Animator.StringToHash("Back");
    private static readonly int Right = Animator.StringToHash("Right");
    private static readonly int Left = Animator.StringToHash("Left");
    
    [SerializeField] public Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetBool(IsMoving, obj.magnitude > .1f);

        if (obj.magnitude < .1f) return;

        animator.SetBool(Front, false);
        animator.SetBool(Back, false);
        animator.SetBool(Right, false);
        animator.SetBool(Left, false);

        if (Mathf.Abs(obj.x) > Mathf.Abs(obj.y))  
        {
            if (obj.x > 0) animator.SetBool(Right, true);
            else if (obj.x < 0) animator.SetBool(Left, true);
        }
        else 
        {
            if (obj.y > 0) animator.SetBool(Back, true);
            else if (obj.y < 0) animator.SetBool(Front, true);
        }

    }



}
