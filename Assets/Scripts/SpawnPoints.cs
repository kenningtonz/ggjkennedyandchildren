using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject[] bones;
    public Vector3[] spawnPoints;

    void Start()
    {
        Instantiate(bones[0], spawnPoints[0]);
    }

    void Update()
    {
        
    }
}
