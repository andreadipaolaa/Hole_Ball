using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    /*public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }*/

    public void QuitButton()
    {
        Application.Quit();
    }

}
