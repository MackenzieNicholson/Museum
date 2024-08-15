using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class KeyDetector : MonoBehaviour
{
    private TextMeshPro display;

    private KeyPadControll keyPadControll;
    // Start is called before the first frame update
    void Start()
    {
        display = GameObject.FindGameObjectWithTag("Display").GetComponentInChildren<TextMeshPro>();
        display.text = "";

        keyPadControll = GameObject.FindGameObjectWithTag("KeyPad").GetComponent<KeyPadControll>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("KeyPadButton"))
        {
            var Key = other.GetComponentInChildren<TextMeshPro>();
            if(Key !=null)
            {
                var keyFeedBack = other.gameObject.GetComponent<KeyFeedback>();

                if(Key.text == "Back")
                {
                    if(display.text.Length > 0) 
                       display.text = display.text.Substring(0, display.text.Length - 1);
                    
                }
                else if (Key.text == "Enter")
                {
                    var accessGranted = false;
                    if(display.text.Length > 0)
                    {
                        accessGranted = keyPadControll.CheckIfCorrect(Convert.ToInt32(display.text));
                    }

                    if(accessGranted == true)
                    {
                        display.text = "Start";
                    }
                    else
                    {
                        display.text = "Retry";
                    }
                
                }
                else if (Key.text == "Cancel")
                {
                    display.text = " ";
                }
                else
                {
                    bool onlyNumbers = int.TryParse(display.text, out int value);
                    if(onlyNumbers == false) 
                    {
                        display.text = " ";
                    }

                    if (display.text.Length < 4)
                        display.text += Key.text;
                }
                keyFeedBack.keyHit = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
