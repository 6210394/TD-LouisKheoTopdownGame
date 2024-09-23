using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickup
{
    public int keyID = 0;

    protected override void Execute()
    {
        GameManager.instance.AddToInventory("Key" + keyID);
        base.Execute();
    }

}
