using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositioner : MonoBehaviour
{
    [SerializeField] float xPosition;


    void Start()
    {
        
    }

    void Update()
    {
        xPosition = Random.Range(-9, 10);
        transform.position = new Vector2(xPosition, transform.position.y);
    }
}
