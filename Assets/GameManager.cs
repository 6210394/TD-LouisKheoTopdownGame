using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;


    [SerializeField]
    private int score;
    public int scoreAdded = 100000;


    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score += scoreAdded;
    }
}
