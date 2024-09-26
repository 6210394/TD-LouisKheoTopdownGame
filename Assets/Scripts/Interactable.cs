using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CircleCollider2D))]
public class Interactable : MonoBehaviour
{
    CircleCollider2D interactCollider;
    public bool isInteractable = false;
    public string sceneToLoad = "GameScene";

    KeyCode interactKey = KeyCode.Space;

    // Start is called before the first frame update
    void Start()
    {
        interactCollider = GetComponent<CircleCollider2D>();
        interactCollider.isTrigger = true;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if(isInteractable && Input.GetKeyDown(interactKey))
        {
            Interact();
        }
    }

    protected virtual void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        SceneManager.LoadScene(sceneToLoad);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isInteractable = true;
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isInteractable = false;
        }
    }
}
