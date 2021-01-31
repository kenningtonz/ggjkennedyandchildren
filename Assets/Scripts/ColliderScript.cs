using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColliderScript : MonoBehaviour
{
    public int BoneScore = 0;
    public GameObject bonestext;
    public GameObject timertext;
    public float Timer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        timertext.GetComponent<Text>().text = Timer.ToString("#.0");
    }

    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "Collectable")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(col.gameObject);
                BoneScore++;
            Debug.Log("collected!");
                bonestext.GetComponent<Text>().text = BoneScore.ToString("#");

                if (BoneScore == 1)
                {
                    universalvaribles.EndTime = Timer;
                    SceneManager.LoadScene("EndScrean");
                }
            }
        }
    }
}
