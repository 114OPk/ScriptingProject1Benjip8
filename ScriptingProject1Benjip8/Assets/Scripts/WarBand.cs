using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start () 
    {
        Humanoid human = new Humanoid();
        Enemy1 enemy1 = new Enemy1();
        Orc orc = new Orc();

        human.Yell();
        enemy1.Yell();
        orc.Yell();
    }
}