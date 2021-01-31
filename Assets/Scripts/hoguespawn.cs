using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoguespawn : MonoBehaviour
{
    public GameObject hogue;
    public Vector3[] spawnPoints;
    private int randomMM;


    void Start()
    {

        Random.InitState(System.DateTime.Now.Millisecond);


        randomMM = Random.Range(0, 5);
        hogue.transform.transform.position = spawnPoints[randomMM];



    }
}
