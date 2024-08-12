using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadControll : MonoBehaviour
{
    public int correctCombination;
    public bool accessGranted = false;

    //public Light spotlight;

    // Start is called before the first frame update
    private void Start()
    {
        //spotlight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(accessGranted == true)
        {
           // spotLight.enabled = true;
            accessGranted = false;
        }
    }

    public bool CheckIfCorrect(int combination)
    {
        if(combination == correctCombination)
        {
            accessGranted = true;
            return true;
        }
        return false;
    }
}
