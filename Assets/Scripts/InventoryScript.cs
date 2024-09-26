using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public static InventoryScript instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    public bool hasFloater = false;
    [SerializeField]
    public SpriteRenderer floaterVisuals;

    #region Inventory Management

    [SerializeField]
    private List<string> playerInventory = new List<string>();

    public void AddToInventory(string item)
    {
        playerInventory.Add(item);
    }

    public void RemoveFromInventory(string item)
    {
        playerInventory.Remove(item);
    }

    public bool CheckInventory(string item)
    {
        return playerInventory.Contains(item);
    }
    #endregion
}
