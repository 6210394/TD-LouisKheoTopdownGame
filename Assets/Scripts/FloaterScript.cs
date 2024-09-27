using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterScript : Pickup
{
    protected override void Execute()
    {
        FindAnyObjectByType<InventoryScript>().hasFloater = true;
        foreach (GameObject shallowWater in GameObject.FindGameObjectsWithTag("Water"))
        {
            shallowWater.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        base.Execute();
    }
}
