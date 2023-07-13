using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public static HungerBar instance;

    public Slider HungerSlider;
    public float Hunger;
    float maxHunger = 100f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
           
        }
       
    }

    void Start()
    {
        Hunger = maxHunger;
    }

    void Update()
    {
        HungerSlider.value = Hunger;

        if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow))
        {
            Hunger -= 1f * Time.deltaTime;
        }
    }

    public void IncreaseHunger(float amount)
    {
        Hunger += amount;
        Hunger = Mathf.Clamp(Hunger, 0f, maxHunger);
    }
}
