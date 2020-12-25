using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogButtonClick : MonoBehaviour
{
    public void Hello()
    {
        Debug.Log("Hello! You pressed on DOGE!");
    }
    public void CloseDoge(GameObject ClosingObject)
    {
        ClosingObject.active = !ClosingObject.active;
    }
}
