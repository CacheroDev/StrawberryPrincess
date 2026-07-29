using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessRun : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Run");
    }


    void Update()
    {
        
    }
}
