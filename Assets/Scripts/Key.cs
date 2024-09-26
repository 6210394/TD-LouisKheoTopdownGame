using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Key : Pickup
{
    public int keyID = 0;

    protected override void Execute()
    {
        InventoryScript.instance.AddToInventory(this.gameObject.name + keyID);
        base.Execute();
    }

}
