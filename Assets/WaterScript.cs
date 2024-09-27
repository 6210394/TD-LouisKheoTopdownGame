using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : SpeedZone
{
    InventoryScript inventoryScript;

    private void Start()
    {
        inventoryScript = FindAnyObjectByType<InventoryScript>();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        inventoryScript.floaterVisuals.enabled = true;
        base.OnTriggerEnter2D(collision);
    }

    protected override void OnTriggerExit2D(Collider2D collision)
    {
        inventoryScript.floaterVisuals.enabled = false;
        base.OnTriggerExit2D(collision);
    }

}
