using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneChanger : MonoBehaviour
{
    public float changeTime;
    public string sceneName;

    private bool collided = false;

    private void Update()
    {
        if (collided)
        {
            changeTime -= Time.deltaTime;
            if (changeTime <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collided = true;
        }
    }
}
