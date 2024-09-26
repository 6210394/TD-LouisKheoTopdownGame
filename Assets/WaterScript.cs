using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : SpeedZone
{
    
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        InventoryScript.instance.floaterVisuals.enabled = true;
        base.OnTriggerEnter2D(collision);
    }

    protected override void OnTriggerExit2D(Collider2D collision)
    {
        InventoryScript.instance.floaterVisuals.enabled = false;
        base.OnTriggerExit2D(collision);
    }

}
