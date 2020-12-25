using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public GameObject myPrefab;
    public Transform InstPos;
    // Start is called before the first frame update
    void Start()
    {
        myPrefab = Resources.Load("Cube") as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {

        Instantiate(myPrefab, InstPos);
    }
}
