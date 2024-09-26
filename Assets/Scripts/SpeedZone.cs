using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedZone : MonoBehaviour
{
    public float speedModifier = 1.5f;
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MovementManager movementManager = collision.gameObject.GetComponent<MovementManager>();
            movementManager.AddSpeedModifier("SpeedZone", speedModifier);
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MovementManager movementManager = collision.gameObject.GetComponent<MovementManager>();
            movementManager.RemoveSpeedModifier("SpeedZone");
        }
    }
}
