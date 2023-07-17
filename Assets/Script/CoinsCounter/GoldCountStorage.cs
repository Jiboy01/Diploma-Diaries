using UnityEngine;

public static class GoldCountStorage
{
    private const string GoldCountKey = "GoldCount";

    public static void SaveGoldCount(int goldCount)
    {
        PlayerPrefs.SetInt(GoldCountKey, goldCount);
    }

    public static int LoadGoldCount()
    {
        return PlayerPrefs.GetInt(GoldCountKey, 0);
    }
}
