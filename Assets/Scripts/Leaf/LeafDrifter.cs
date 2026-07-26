using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDrifter : MonoBehaviour
{
    SpriteRenderer spriteRen;
    [SerializeField] float lifeDuration;
    [SerializeField] float flipTime;

    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
        Destroy(gameObject, lifeDuration);
        StartCoroutine(DriftByWind());
    }

    IEnumerator DriftByWind()
    {
        while (true)
        {
            spriteRen.flipY = false;
            yield return new WaitForSeconds(flipTime);
            spriteRen.flipY = true;
            yield return new WaitForSeconds(flipTime);
        }
    }
}
