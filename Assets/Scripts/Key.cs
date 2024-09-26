using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Key : Pickup
{
    public int keyID = 0;

    protected override void Execute()
    {
        GameObject keyCopy = new GameObject();
        keyCopy.name = "Key" + keyID;
        InventoryScript.instance.AddToInventory(keyCopy);
        base.Execute();
    }

}
