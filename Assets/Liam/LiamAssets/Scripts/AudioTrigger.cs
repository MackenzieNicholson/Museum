using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;

public class AudioTrigger : MonoBehaviour
{
    public bool isSelected = false;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SelectEnter()
    {
        isSelected = true;
    }

    public void SelectExit()
    {
        isSelected = false;
    }

    public void Activate()
    {
        Debug.Log("Audio played");
    }

}
