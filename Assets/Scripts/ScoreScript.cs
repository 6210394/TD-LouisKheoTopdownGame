using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + GameManager.instance.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
