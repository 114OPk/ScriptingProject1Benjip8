using System.Collections;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x poisition of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 10f)
        {
            Debug.Log("Hello there... how are you?");
        }
    }
}
