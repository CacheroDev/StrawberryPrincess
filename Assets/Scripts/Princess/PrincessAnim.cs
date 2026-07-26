using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessAnim: MonoBehaviour
{
    [SerializeField] Movement move;
    [SerializeField] PrincessJump jump;
    [SerializeField] GroundChecker checker;
    Animator anim;
    [SerializeField] ParticleSystem smokeFX;
    
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
            smokeFX.Play();
        }
        else if (move.isWalking)
        {
            anim.Play("Run");
            smokeFX.Play();
        }
        else
        {
            anim.Play("Idle");
        }
    }
}
