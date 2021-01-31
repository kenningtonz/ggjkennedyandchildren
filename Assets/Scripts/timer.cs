using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject timetext;
    public GameObject text1;
    public GameObject text2;
    private string texttext;

    // Start is called before the first frame update
    void Start()
    {
        texttext = "hogue is less dissapointed in you";
    }

    // Update is called once per frame
    void Update()
    {
        //(if universalvaribles < certainnumber)
        //  {
      //  text1.GetComponent<Text>().text = texttext;
     //   text2.GetComponent<Text>().text = texttext;
        //  }
        timetext.GetComponent<Text>().text = universalvaribles.EndTime.ToString("#.0");
    }
}
