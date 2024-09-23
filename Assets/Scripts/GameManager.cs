using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

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

    #region Score Management

        [SerializeField]
        private int score;
        public int scoreAdded = 100000;
        public void AddScore()
        {
            score += scoreAdded;
        }
    #endregion

    #region Inventory Management

        [SerializeField]
        private List<string> playerInventory = new List<string>();

        public void AddToInventory(string item)
        {
            playerInventory.Add(item);
        }

        public void RemoveFromInventory(string item)
        {
            playerInventory.Remove(item);
        }

        public bool CheckInventory(string item)
        {
            return playerInventory.Contains(item);
        }
    #endregion
}
