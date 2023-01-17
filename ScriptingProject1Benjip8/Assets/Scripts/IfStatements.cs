using System.Collections;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float Light = 85.0f;
    float BrightLight = 70.0f;
    float DarkLight = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            BlackOut();

        Light -= Time.deltaTime * 5f;
    }


    void BlackOut()
    {
        if (Light > BrightLight)
        {
            print("Too Bright.");
        }
        else if (Light < DarkLight)
        {
            print("Too Dark.");
        }
        else
        {
            print("Better Light.");
        }
    }
}