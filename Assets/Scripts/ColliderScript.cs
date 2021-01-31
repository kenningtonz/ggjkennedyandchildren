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
    public float Timer = 0;
    public AudioClip pickupsound;
    private AudioSource audioSource;
    public GameObject presse;
 //   public GameObject Manager;

// Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        timertext.GetComponent<Text>().text = Timer.ToString("#");
        audioSource = GetComponent<AudioSource>();

    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Collectable")
        {
            presse.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                presse.SetActive(false);
                Destroy(col.gameObject);
                BoneScore++;

              //  Manager.GetComponent<SpawnPoints>().spawnedbones.Remove(col.gameObject);
              //  Manager.GetComponent<SpawnPoints>().currentsize--;

            Debug.Log("collected!");
                bonestext.GetComponent<Text>().text = BoneScore.ToString("#");
                audioSource.PlayOneShot(pickupsound, 0.8f);

                if (BoneScore == 7)
                {
                    universalvaribles.EndTime = Timer;

                    SceneManager.LoadScene("EndScrean");
                }
            }
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Collectable")
        {
            presse.SetActive(false);
          
        }
    }
}
