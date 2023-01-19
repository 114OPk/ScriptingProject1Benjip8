using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = true;

        do
        {
            print("Welcome to Super Mario Bros. The Movie by Universal Studios!");

        } while (shouldContinue == false);
    }
}
