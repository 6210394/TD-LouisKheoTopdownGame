using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FloaterScript : Pickup
{
    protected override void Execute()
    {
        FindAnyObjectByType<InventoryScript>().hasFloater = true;
        foreach (GameObject shallowWater in GameObject.FindGameObjectsWithTag("Water"))
        {
            if(shallowWater.GetComponent<TilemapCollider2D>() != null)
            {
                shallowWater.GetComponent<TilemapCollider2D>().isTrigger = true;
            }
            if(shallowWater.GetComponent<BoxCollider2D>() != null)
            {
                shallowWater.GetComponent<BoxCollider2D>().isTrigger = true;
            }
        }
        base.Execute();
    }
}
