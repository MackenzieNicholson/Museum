using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixMatchScript : MonoBehaviour
{
    [SerializeField] private string objectType;

    public GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "Entered trigger");
        if(objectType == other.name)
        {
            gameManager.objectMatchCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "Exited trigger");
        if (objectType == other.name)
        {
            gameManager.objectMatchCount--;
        }
    }
}
