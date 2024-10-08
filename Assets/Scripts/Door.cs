using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : Interactable
{
    public int requiredKeyID = 0;

    protected override void Interact()
    {
        
        if (FindAnyObjectByType<InventoryScript>().CheckInventory("Key" + requiredKeyID))
        {
            FindAnyObjectByType<InventoryScript>().RemoveFromInventory("Key" + requiredKeyID);
            OpenDoor();
        }
        
        else
        {
            Debug.Log("Locked.");
            return;
        }
        
    }

    private void OpenDoor()
    {
        Destroy(gameObject);
    }
}
