using System.Collections;
using UnityEngine;

public class VariableAndFunctions : MonoBehaviour
{
    int myInt = 17;


    void Start()
    {
        myInt = MultiplyByFour(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByFour(int number)
    {
        int result;
        result = number * 4;
        return result;
    }
}
