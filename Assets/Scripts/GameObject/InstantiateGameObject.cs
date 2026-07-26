using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGameObject : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bubble;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player.GetComponent<Movement>().isWalking)
        {
            Instantiate(bubble, transform.position, transform.rotation);
        }
    }
}
