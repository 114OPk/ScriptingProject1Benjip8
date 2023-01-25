using System.Collections;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 4;


    private int beta = 0;
    private int gamma = 4;


    private AnotherClass myOtherClass;


    void Start()
    {
        alpha = 20;

        myOtherClass = new AnotherClass();
        myOtherClass.CandyMachine(alpha, myOtherClass.chocolates);
    }

    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}