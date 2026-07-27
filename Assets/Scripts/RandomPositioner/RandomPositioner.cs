using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositioner : MonoBehaviour
{
    [SerializeField] float spawnerXPosition;
    [SerializeField] GameObject virtualCam;
    [SerializeField] Vector2 cameraPos;

    void Start()
    {
        virtualCam = GameObject.FindGameObjectWithTag("Virtual_Cam");
    }

    void Update()
    {
        cameraPos = virtualCam.transform.position;
        spawnerXPosition = Random.Range(-9, 10);
        transform.position = new Vector3(cameraPos.x + spawnerXPosition, transform.position.y, transform.position.z);

        //transform.localPosition = new Vector2(xPosition, transform.localPosition.y);
    }
}
