using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string Quiz; // The name of the scene to be triggered (SceneB)

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Replace KeyCode.Space with your desired input trigger
        {
            SceneManager.LoadScene(Quiz); // Load the triggered scene (SceneB)
        }
    }
}