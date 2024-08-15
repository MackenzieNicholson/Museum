using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public bool isMusicDoor;
    public bool isArtDoor;
    public bool isLobbyDoor;

    public void ActivateDoor()
    {
        if (isMusicDoor == true)
        {
            SceneManager.LoadScene("LiamTestScene");
        }
        else if (isArtDoor == true)
        {
            SceneManager.LoadScene("famous art");
        }
        else if (isLobbyDoor == true)
        {
            SceneManager.LoadScene("Lobby");
        }
    }
}
