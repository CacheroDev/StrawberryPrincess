using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessJump : MonoBehaviour
{
    [SerializeField] KeyCode jump;
    [SerializeField] float force;
    [SerializeField] public bool isJumping;
    [SerializeField] GroundChecker checker;
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        checker = GameObject.FindGameObjectWithTag("Feet").GetComponent<GroundChecker>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jump) && checker.isGrounded)
        {
            body.AddForce(Vector2.up * force);
            isJumping = true;
        }
        else
            isJumping = false;
    }
}
