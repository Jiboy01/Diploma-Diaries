using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private static int gold = 0;
    private static int exp = 0;

    public static void AddGold(int amount)
    {
        gold += amount;
    }

    public static void AddExp(int amount)
    {
        exp += amount;
    }
}
