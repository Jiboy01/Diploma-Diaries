using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Xml.Serialization;

public class NPC : MonoBehaviour

{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;
    public bool playerInRange;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && playerInRange) 
        {
            if(dialogBox.activeInHierarchy) 
            {
                dialogBox.SetActive(false);
            } else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;   
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player left range");
        }
    }
}