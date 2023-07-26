using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    // Declare the public static instance variable
    public static CoinCounter instance;

    public TMP_Text coinText;
    private int currentCoins = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep the CoinCounter object when loading a new scene
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances of the script
        }
    }

    private void Start()
    {
        // Load the gold count from the persistent storage script
        currentCoins = PlayerPrefs.GetInt("CurrentCoins", 10);
        UpdateCoinText();
    }

    public void IncreaseCoins(int value)
    {
        currentCoins += value;
        UpdateCoinText();

        // Save the updated gold count to the persistent storage script
        PlayerPrefs.SetInt("CurrentCoins", currentCoins);
    }

    public int GetCurrentCoins()
    {
        return currentCoins;
    }

    private void UpdateCoinText()
    {
        coinText.text = "FOOD : " + currentCoins.ToString();
    }
}
