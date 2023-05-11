using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Humanoid
{
    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy1 version of the Yell() method");
    }
}