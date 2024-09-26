using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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


        #region Inventory Management

        [SerializeField]
        private List<GameObject> playerInventory = new List<GameObject>();

        public void AddToInventory(GameObject item)
        {
            playerInventory.Add(item);
        }

        public void RemoveFromInventory(string item)
        {
            playerInventory.Remove(FindInventoryItem(item));
        }

        public bool CheckInventory(GameObject itemLock)
        {
            foreach (GameObject inventoryItem in playerInventory)
            {
                if (inventoryItem.name == "Key" + itemLock.GetComponent<Door>().requiredKeyID)
                {
                    return true;
                }
                //add checks for different items
            }
            return false;
        }

        public GameObject FindInventoryItem(string searchName)
        {
            foreach (GameObject inventoryItem in playerInventory)
            {
                if (inventoryItem.name == searchName)
                {
                    return inventoryItem;
                }
            }
            return null;
        }        
        
    #endregion
}
