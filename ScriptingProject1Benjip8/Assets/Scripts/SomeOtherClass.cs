using System.Collections;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        //The specific Add method called will depend on
        //the arguments passed in.
        Debug.Log(myClass.Add(6, 9));
        Debug.Log(myClass.Add("What are you", "doing now!?"));
    }
}