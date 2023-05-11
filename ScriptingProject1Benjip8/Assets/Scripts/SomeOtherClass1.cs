using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass1 : MonoBehaviour
{
    void Start()
    {
        SomeClass1 myClass = new SomeClass1();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}