using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public int BoneScore = 0;
    //public GameObject gameObject;

    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "Collectable")
        {
            //Debug.Log("ouch a rock");

            if (Input.GetKey(KeyCode.E))
            {
                Destroy(col.gameObject);
                BoneScore++;
            }
        }
    }
}
