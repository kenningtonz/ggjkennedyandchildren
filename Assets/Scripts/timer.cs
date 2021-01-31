using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject text;
    public float Timer;
    private Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_text = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        text.GetComponent<Text>().text = Timer.ToString("#.0");
    }
}
