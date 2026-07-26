using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int randomIndex;
    [SerializeField] float shiftTime;
    
    void Start()
    {
        
        StartCoroutine(VerticalShifter());
    }

    void Update()
    {
        shiftTime = Random.Range(2, 5);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    IEnumerator VerticalShifter()
    {
        while (true)
        {
            yield return new WaitForSeconds(shiftTime);
            randomIndex = Random.Range(0, 4);
            if (randomIndex == 0)
            {
                speed = 0.25f;
            }
            else if (randomIndex == 1)
            {
                speed = 2f;
            }
            else if (randomIndex == 2)
            {
                speed = -0.2f;
            }
            else
            {
                speed = -0.1f;
            }
        }
        
    }
}
