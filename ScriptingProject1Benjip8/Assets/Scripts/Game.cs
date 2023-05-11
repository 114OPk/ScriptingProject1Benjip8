using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player();

        //Properties can be used just like variables
        myPlayer.Experience = 10;
        int x = myPlayer.Experience;
    }
}