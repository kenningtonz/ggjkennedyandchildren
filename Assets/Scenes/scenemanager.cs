using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{

    public void title()
    {
        SceneManager.LoadScene("Title");
    }

    public void end()
    {
        SceneManager.LoadScene("EndScrean");
    }

    public void play()
    {
        SceneManager.LoadScene("play");
    }
}
