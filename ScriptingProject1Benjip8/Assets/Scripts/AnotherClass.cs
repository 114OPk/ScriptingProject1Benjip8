using System.Collections;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int chocolates;
    public int candies;


    private int Sprite;
    private int Fanta;


    public void CandyMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Candy total: " + answer);
    }


    private void SodaVendingMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Soda total: " + answer);
    }
}