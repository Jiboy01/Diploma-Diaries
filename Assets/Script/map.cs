using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public GameObject mapCanvas;

    // Start is called before the first frame update
    void Start()
    {
        // Hide the map canvas when the game starts
        mapCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check for Tab key press
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Toggle the map canvas when the Tab key is pressed
            mapCanvas.SetActive(!mapCanvas.activeSelf);
        }
    }
}
