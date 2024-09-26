using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public string sceneName = "GameScene";
    public void LoadScene()
    {
        // Load the scene with the name "GameScene"
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        GameManager.instance.score = 0;
    }
}
