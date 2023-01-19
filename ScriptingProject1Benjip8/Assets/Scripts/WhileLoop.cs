using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int soldingDevices = 6;


    void Start()
    {
        while(soldingDevices > 0)
        {
            Debug.Log ("I have sold the computer!");
            soldingDevices--;
        }
    }
}
