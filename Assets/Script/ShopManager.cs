using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    // Declare the public static instance variable
    public static ShopManager instance;

    // Coins property to access coins through CoinCounter
    public int Coins
    {
        get { return CoinCounter.instance.GetCurrentCoins(); }
        set { CoinCounter.instance.IncreaseCoins(value); }
    }

    public Item[] items;

    // References
    public TMP_Text coinText;
    public GameObject Shop;
    public Transform shopContent;
    public GameObject itemPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        Coins = 10; // Set the initial coins value to 10.

        foreach (Item item in items)
        {
            GameObject food = Instantiate(itemPrefab, shopContent);
            item.itemRef = food;

            foreach (Transform child in food.transform)
            {
                if (child.gameObject.name == "Quantity")
                {
                    child.gameObject.GetComponent<TextMeshProUGUI>().text = item.quantity.ToString();
                }
                else if (child.gameObject.name == "Cost")
                {
                    child.gameObject.GetComponent<TextMeshProUGUI>().text = "$" + item.cost.ToString();
                }
                else if (child.gameObject.name == "Name")
                {
                    child.gameObject.GetComponent<TextMeshProUGUI>().text = item.name;
                }
                else if (child.gameObject.name == "Image")
                {
                    child.gameObject.GetComponent<Image>().sprite = item.image;
                }
            }

            food.GetComponent<Button>().onClick.AddListener(() =>
            {
                BuyFood(item);
            });
        }
    }

    public void BuyFood(Item item)
    {
        if (Coins >= item.cost)
        {
            Coins -= item.cost;
            item.quantity++;
            item.itemRef.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = item.quantity.ToString();
        }
    }

    public void ToggleShop()
    {
        if (Shop != null)
        {
            Shop.SetActive(!Shop.activeSelf);
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + Coins.ToString();
    }

    [System.Serializable]
    public class Item
    {
        public string name;
        public int cost;
        public Sprite image;
        [HideInInspector] public int quantity;
        [HideInInspector] public GameObject itemRef;
    }
}
