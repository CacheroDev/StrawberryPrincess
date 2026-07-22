using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //[SerializeField] KeyCode left;
    //[SerializeField] KeyCode right;
    [SerializeField] float speed;
    [SerializeField] float horizontal;
    [SerializeField] public bool isWalking;
    [SerializeField] public bool faceLeft;
    [SerializeField] public bool faceRight;
    //[SerializeField] GroundChecker gchecker;
    //[SerializeField] Vector2 initPosition;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //initPosition = transform.position;
        //gchecker = GameObject.FindGameObjectWithTag("Feet").GetComponent<GroundChecker>();
    }
        
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (horizontal < 0)
        {
            isWalking = true;
            faceLeft = true;
            faceRight = false;
        }
        else if (horizontal > 0)
        {
            isWalking = true;
            faceLeft = false;
            faceRight = true;
        }
        else
            isWalking = false;
    }
}
