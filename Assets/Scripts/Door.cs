using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : Pickup
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public int requiredKeyID = 0;
    protected override void Execute()
    {
        
        if (InventoryScript.instance.CheckInventory("Key" + requiredKeyID))
        {
            InventoryScript.instance.RemoveFromInventory("Key" + requiredKeyID);
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
        animator.SetTrigger("isOpen");
    }
}
