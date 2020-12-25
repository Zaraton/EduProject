using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private int presses = 0;
    public Text UIText;
   

    // Update is called once per frame
    void Update()
    {
        UIText.text = "Pressed: " + presses;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            presses++;
        }
    }
}
