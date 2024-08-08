using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    public GameObject musicBlock;
    public GameObject musicDoor;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.musicFinished == true)
        {
            musicDoor.SetActive(false);
            musicBlock.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
