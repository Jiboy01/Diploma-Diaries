using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapToggle : MonoBehaviour
{
    [SerializeField] private GameObject mapCanvas;
    private bool isMapActive = false;

    private void Start()
    {
        mapCanvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleMapCanvas();
        }
    }

    private void ToggleMapCanvas()
    {
        isMapActive = !isMapActive; // Flip the state (true to false, false to true)

        // Set the map canvas active/inactive based on the new state
        mapCanvas.SetActive(isMapActive);
    }
}
