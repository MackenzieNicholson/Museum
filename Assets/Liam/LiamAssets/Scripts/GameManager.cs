using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;

public class GameManager : MonoBehaviour
{
    public int objectMatchCount;
    private bool win = false;
    private bool finished = false;

    public GameObject winCube;


    private void Update()
    {
        if (objectMatchCount == 6 && finished == false)
        {
            win = true;
            finished = true;
        }

        if(win == true && finished == true)
        {
            RoomWin();
            win = false;
        }
    }

    public void RoomWin()
    {
        Debug.Log("You Win");
        winCube.SetActive(true);
    }

}
