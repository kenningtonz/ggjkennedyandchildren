using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject[] bones;
    public Vector3[] spawnPoints;

    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            Instantiate(bones[i], spawnPoints[i], Quaternion.identity);
        }
    }
}
