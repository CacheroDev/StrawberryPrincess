using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAlternatingStates : MonoBehaviour
{
    //[Header("Initial Animation State: On-1, On/Off-2, Off-3")]
    //[SerializeField] int animationState;

    [Header("Time Between Animation States")]
    [SerializeField] float initialTime;
    [SerializeField] float inBetweenTime;

    Animator anim;



    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(AnimationFlow());
    }

    IEnumerator AnimationFlow()
    {
        yield return new WaitForSeconds(initialTime);
        while (true)
        {
            anim.Play("LampOn");
            yield return new WaitForSeconds(inBetweenTime);
            anim.Play("LampOn");
            yield return new WaitForSeconds(inBetweenTime);
            anim.Play("LampOff");
            yield return new WaitForSeconds(inBetweenTime);
            anim.Play("LampOnOff");
            yield return new WaitForSeconds(inBetweenTime);
        }
    }
}
