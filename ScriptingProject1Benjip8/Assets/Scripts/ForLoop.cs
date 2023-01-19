using System.Collections;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numPapers = 8;


    void Start()
    {
        for (int i = 0; i < numPapers; i++)
        {
            Debug.Log("Making a paper: " + i);
        }
    }
}