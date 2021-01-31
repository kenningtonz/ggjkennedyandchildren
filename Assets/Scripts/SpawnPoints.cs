using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject[] bones;
    public List<Vector3> spawnPoints = new List<Vector3>();
    public int randomMM;
    private int maxnum;
    private Quaternion rotate;

  


    void Start()
    {
        rotate = new Quaternion(0, 0, -180, 0);
        maxnum = 23;
        Random.InitState(System.DateTime.Now.Millisecond);

        for (int i = 0; i < 7; i++)
        {

      randomMM = Random.Range(0, maxnum);

           Instantiate(bones[i], spawnPoints[randomMM], Quaternion.identity);
            
            maxnum--;
          
            spawnPoints.Remove(spawnPoints[randomMM]);
        

        }
        bones[2].transform.localRotation = rotate;
    }


}
