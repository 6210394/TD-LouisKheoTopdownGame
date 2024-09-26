using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterScript : Pickup
{
    protected override void Execute()
    {
        InventoryScript.instance.hasFloater = true;
        foreach (GameObject shallowWater in GameObject.FindGameObjectsWithTag("Water"))
        {
            shallowWater.GetComponent<Collider2D>().isTrigger = true;
        }
        base.Execute();
    }
}
