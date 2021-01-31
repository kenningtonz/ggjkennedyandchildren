using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{


    AudioSource audio;



    // Start is called before the first frame update
    void Start()
    {
      //col = GetComponent<Collider>();
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider col)
    {
      audio.Play();
    }
    private void OnTriggerExit(Collider col)
    {
        audio.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
