using System.Collections;

using UnityEngine;

public class FireOnOff : MonoBehaviour
{
    [Header("Time Between Animation States")]
    [SerializeField] float initialTime;
    [SerializeField] float inBetweenTime;

    CapsuleCollider2D capsuleCol;
    Animator anim;

    void Start()
    {
        capsuleCol = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
        StartCoroutine(AnimationFlow());
    }

    IEnumerator AnimationFlow()
    {
        yield return new WaitForSeconds(initialTime);
        while (true)
        {
            anim.Play("FlameOn");
            capsuleCol.enabled = true;
            yield return new WaitForSeconds(inBetweenTime);
            anim.Play("FlameOff");
            capsuleCol.enabled = false;
            yield return new WaitForSeconds(inBetweenTime);
        }
    }
}
