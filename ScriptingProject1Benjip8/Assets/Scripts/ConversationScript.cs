using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;


    void Start()
    {
        Greet();
    }


    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("It's a me, Mario!");
                break;
            case 4:
                print("Hey Daddy, what doing!");
                break;
            case 3:
                print("I believe I can fly.");
                break;
            case 2:
                print("You Wanna See My Pencil?");
                break;
            case 1:
                print("Pop Goes the Weasel!");
                break;
            default:
                print("What is 9 + 10... 21?");
                break;
        }
    }
}