using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static Vector2 playerPosition;

    [SerializeField]
    private Vector2 customPlayerPosition = Vector2.zero;

    public Vector2 CustomPlayerPosition
    {
        get { return customPlayerPosition; }
        set { customPlayerPosition = value; }
    }
}
