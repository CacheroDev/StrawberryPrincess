using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafFall : MonoBehaviour
{
    [SerializeField] float speed;
    

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
