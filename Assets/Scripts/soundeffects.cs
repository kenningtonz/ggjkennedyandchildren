using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffects : MonoBehaviour
{
    public float timer;
    public AudioClip[] bonesounds;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            audioSource.PlayOneShot(bonesounds[Random.Range(0, 2)], 0.8f);
            timer = 10;
        }
    }
}
