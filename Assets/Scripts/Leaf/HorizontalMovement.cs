using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float inclusiveMin;
    [SerializeField] float exclusiveMax;

    void Start()
    {
        speed = Random.Range(inclusiveMin, exclusiveMax);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
