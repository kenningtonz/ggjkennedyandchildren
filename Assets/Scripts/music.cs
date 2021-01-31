using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{


   
    private AudioSource audioesourse;


    // Start is called before the first frame update
    void Start()
    {

        audioesourse = GetComponent<AudioSource>();
       
    }
 
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "hogue")
        {
            audioesourse.Play();
            Debug.Log("play" + this.name);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "hogue")
        {
            audioesourse.Stop();
            Debug.Log("stop" + this.name);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
