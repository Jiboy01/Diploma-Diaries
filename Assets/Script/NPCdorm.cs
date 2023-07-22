using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NPCdorm : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText; // Use TMP_Text instead of Text
    public string[] dialogue;
    public int index;

    public float wordSpeed;
    public bool playerIsClose;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                ZeroText(); // Use PascalCase for method names
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && dialogueText.text == dialogue[index])
        {
            NextLine();
        }

    }

    public void ZeroText()
    {
        if (dialogueText != null && dialoguePanel != null)
        {
            dialogueText.text = "";
            index = 0;
            dialoguePanel.SetActive(false);
        }
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            if (dialogueText != null)
            {
                dialogueText.text += letter;
            }
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            if (dialogueText != null)
            {
                dialogueText.text = "";
            }
            StartCoroutine(Typing());
        }
        else
        {
            ZeroText(); // Use PascalCase for method names
        }
    }

    private void OnTriggerEnter2D(Collider2D other) // Use correct capitalization
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) // Use correct capitalization
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            ZeroText(); // Use PascalCase for method names
        }
    }
}