using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public string sceneName = "GameScene";
    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        InventoryScript.instance.hasFloater = false;
        if(sceneName == "Start")
        {
            GameManager.instance.score = 0;
        }

    }
}
