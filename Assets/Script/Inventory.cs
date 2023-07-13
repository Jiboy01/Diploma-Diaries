using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Slot
    {
        public int count;
        public int maxAllowed;

        public Slot()
        {
            count = 0;
            maxAllowed = 99;
        }
    }

    public int TotalCoins { get; private set; }
    public List<Slot> slots = new List<Slot>();

    public void AddCoins(int amount)
    {
        TotalCoins += amount;
    }
}
