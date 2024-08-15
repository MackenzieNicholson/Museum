using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;

public class GameManager : MonoBehaviour
{
    public int objectMatchCount;
    private bool win = false;
    public static bool musicFinished = false;

    public GameObject winCube;
    public GameObject blockade;
    public GameObject musicDoor;


    private void Update()
    {
        if (objectMatchCount == 6 && musicFinished == false)
        {
            win = true;
            musicFinished = true;
        }

        if(win == true && musicFinished == true)
        {
            RoomWin();
            win = false;
        }
    }

    public void RoomWin()
    {
        Debug.Log("You Win");
        winCube.SetActive(true);
        blockade.SetActive(false);
        musicDoor.SetActive(true);
    }

}
