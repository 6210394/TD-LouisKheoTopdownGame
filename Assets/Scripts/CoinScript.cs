using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : Pickup
{
    protected override void Execute()
    {
        GameManager.instance.AddScore();
        base.Execute();
    }
}
