using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessAnim: MonoBehaviour
{
    [SerializeField] Movement move;
    [SerializeField] PrincessJump jump;
    [SerializeField] GroundChecker checker;
    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        checker = GameObject.FindGameObjectWithTag("Feet").GetComponent<GroundChecker>();
        move = GetComponent<Movement>();
        jump = GetComponent<PrincessJump>();
    }

    void Update()
    {
        //Facing
        if (move.faceLeft)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (move.faceRight)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else
        {
            
        }
            
        //Animation
        if (jump.isJumping || !checker.isGrounded)
        {
            anim.Play("Jump");
        }
        else if (move.isWalking)
        {
            anim.Play("Run");
        }
        else
        {
            anim.Play("Idle");
        }
    }
}
