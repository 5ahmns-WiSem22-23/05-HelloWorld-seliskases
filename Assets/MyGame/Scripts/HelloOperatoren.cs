using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    private void Start()
    {
        float x = 0;

        Debug.Log("x: " + x);
        x++;
        Debug.Log("After x++: " + x);

        x *= 2;
        Debug.Log("After x *= 2: " + x);

        x /= 5;
        Debug.Log("After x/= 5: " + x);

        bool myBool = false;
        Debug.Log("myBool: " + myBool);

        myBool = x != 2;
        Debug.Log("After myBool = x != 2: " + myBool);

        myBool = false;
        Debug.Log("After myBool = false: " + myBool);

    }
}
