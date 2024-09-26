using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : Pickup
{
    public int scoreValue = 100;
    protected override void Execute()
    {
        GameManager.instance.AddScore(scoreValue);
        base.Execute();
    }
}
