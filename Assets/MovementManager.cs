using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
public bool canMoveHorizontally = true;
public bool canMoveVertically = true;

public float moveSpeed = 5f;
public float sprintSpeedModifier = 2f;

public float speedModifier;
public Dictionary<string, float> speedModifierList = new Dictionary<string, float>();


public float moveX = 0f;
public float moveY = 0f;

    void Update()
    {
        if (canMoveHorizontally)
        {
            moveX = Input.GetAxis("Horizontal");
        }
        if (canMoveVertically)
        {
            moveY = Input.GetAxis("Vertical");
        }

        Vector3 movement = new Vector3(moveX, moveY, 0f);
        if (movement.magnitude > 1)
            movement.Normalize();


        if(Input.GetKey(KeyCode.LeftShift))
        {
            if(!speedModifierList.ContainsKey("Sprint"))
            {
                AddSpeedModifier("Sprint", sprintSpeedModifier);
            }
        }
        else
        {
            if(speedModifierList.ContainsKey("Sprint"))
            {
                RemoveSpeedModifier("Sprint");
            }
        }

        if(speedModifier == 0)
        {
            speedModifier = 1;
        }

        movement *= speedModifier;
        transform.position = Vector3.Lerp(transform.position, transform.position + movement, moveSpeed * Time.deltaTime);
    }

    public void AddSpeedModifier(string name, float modifier)
    {
        speedModifierList[name] = modifier;
        CalculateSpeedModifier();
    }

    public void RemoveSpeedModifier(string name)
    {
        if (speedModifierList.ContainsKey(name))
        {
            speedModifierList.Remove(name);
        }
        CalculateSpeedModifier();
    }

    public void CalculateSpeedModifier()
    {
        speedModifier = 1;
        foreach (float modifier in speedModifierList.Values)
        {
            speedModifier *= modifier;
        }
    }
}