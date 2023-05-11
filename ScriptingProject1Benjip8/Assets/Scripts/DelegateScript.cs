using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;


    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(25);

        myDelegate = DoubleNum;
        myDelegate(25);
    }

    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double Num: " + num * 2);
    }
}