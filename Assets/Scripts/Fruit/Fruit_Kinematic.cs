using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_Kinematic : MonoBehaviour
{
    [Header("Time Between Falling and Rising")]
    [SerializeField] float initialTime;
    [SerializeField] float inBetweenTime;

    Vector2 initialPos;

    void Start()
    {
        initialPos = transform.position;
        StartCoroutine(UpAndDown());        
    }

    IEnumerator UpAndDown()
    {
        yield return new WaitForSeconds(initialTime);
        while (true)
        {
            transform.position = initialPos;
            yield return new WaitForSeconds(inBetweenTime);
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            yield return new WaitForSeconds(inBetweenTime);
        }
    }
}
