using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SFXManager.instance.Audio.PlayOneShot(SFXManager.instance.Click);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
        SFXManager.instance.Audio.PlayOneShot(SFXManager.instance.Click);
    }
}
