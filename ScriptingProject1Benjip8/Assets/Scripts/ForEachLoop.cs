using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{
    void Start()
    {
        string[] strings = new string[5];

        strings[0] = "Strike One";
        strings[1] = "Strike Two";
        strings[2] = "Strike Three";
        strings[3] = "You're Out";
        strings[4] = "Next Player";

        foreach (string item in strings)
        {
            print(item);
        }
    }
}
