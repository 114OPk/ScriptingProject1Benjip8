using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Member variables can be referred to as
    //fields.
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            //Some other code
            return experience;
        }
        set
        {
            //Some other code
            experience = value;
        }
    }

    //Level is a property that converts experience
    //points into the leve of a player automatically
    public int Level
    {
        get
        {
            return experience / 500;
        }
        set
        {
            experience = value * 500;
        }
    }

    //This is an example of an auto-implemented
    //property
    public int Health { get; set; }
}