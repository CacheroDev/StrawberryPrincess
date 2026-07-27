using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] leafPrefab;
    [SerializeField] float spawnTime;
    [SerializeField] int randomIndex;

    void Start()
    {
        StartCoroutine(SpawnLeaf());
    }

    void Update()
    {
        spawnTime = Random.Range(1, 4);
        randomIndex = Random.Range(0, leafPrefab.Length);
    }

    IEnumerator SpawnLeaf()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(leafPrefab[randomIndex], transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnTime);
            Instantiate(leafPrefab[randomIndex], transform.position, transform.rotation);
        }
    }
}
