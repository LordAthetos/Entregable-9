using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // cambia la escena cuando se pulsa el boton
    public void ChangeTo2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void ChangeTo1()
    {
        SceneManager.LoadScene("scene1");
    }
}