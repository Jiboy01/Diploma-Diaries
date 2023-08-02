using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if (SFXManager.instance != null)
        {
            SFXManager.instance.Audio.PlayOneShot(SFXManager.instance.Click);
        }
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");

        if (SFXManager.instance != null)
        {
            SFXManager.instance.Audio.PlayOneShot(SFXManager.instance.Click);
        }

        Application.Quit();
    }

    public void OptionKey()
    {
        // Implement your option settings here
    }
}
